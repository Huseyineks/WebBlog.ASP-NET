﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using ServiceStack;
using System.Security.Claims;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.BusinessLogicLayer.Model.DTOs;
using WebBlog.Entitiy.Entities;

namespace WebBlog.Controllers
{
    public class ArticleController : Controller
    {
        IArticle _article;
        IComment _comment;
        IWebHostEnvironment _webHostEnvironment;
        
        public ArticleController(IArticle article,IComment comment,IWebHostEnvironment webHostEnvironment) { 
        
        _article = article;
        _comment = comment;
        _webHostEnvironment = webHostEnvironment;
        

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Articles() {

            List<Article> articles = _article.GetAll().ToList();

            return View(articles);
        
        
        }

        public IActionResult MyArticles() {

            int? userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToInt();

            List<Article> myArticles = _article.GetClassifiedList(i => i.userId == userId).ToList();
            return View(myArticles);  
        
        
        }

        [HttpGet]
        public IActionResult AddArticle()
        {
         




            return View();
        }

        [HttpPost]
        public IActionResult AddArticle(ArticleDTO article)
        {
            string fileName = UploadFile(article);
            string FullName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value.ToString();

            if (ModelState.IsValid)
            {
                _article.Add(

                    new Article()
                    {
                        Id = article.ID,
                        Author = FullName,
                        Title = article.Title,
                        Description = article.Description,
                        Image = fileName,
                        createdAt = DateTime.Now,
                        userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToInt()
                    }


                    );
                _article.Save();

            }
            else
            {
                return View();
            }

            return RedirectToAction("Index","Home");
        }

        private string UploadFile(ArticleDTO article)
        {
            string? fileName = null;

            if (article.Image != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + '-' + article.Image.FileName;
                string filePath = Path.Combine(uploadDir, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    article.Image.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public IActionResult Details(int ?id) {

            Article article = _article.getComments(id);



            DetailsDTO detailsdto = new DetailsDTO()
            {
                Article = article,

                comment = null
            };
            
                




            return View(detailsdto);
        
        }

        [HttpPost]

        public IActionResult Details(DetailsDTO postedComment)
        {

            var Author = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;

            int ?id = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToInt();

          

            Comment comment = new Comment()
            {
                
                commentAuthor = Author,
                commmentDescription = postedComment.comment.commmentDescription,
                articleId = postedComment.Article.Id,
                userId = id,
                createdAt = DateTime.Now


            };

            _comment.Add(comment);
            _comment.Save();

            return RedirectToAction("Index","Home");


        }

       

        public IActionResult Edit(int? id)
        {
            Article article = _article.Get(i => i.Id == id);

            return View(article);
        }


        [HttpPost]
        public IActionResult Edit(Article obj) {

            Article article = _article.Get(i => i.Id == obj.Id);

            article.Title = obj.Title;
            article.Description = obj.Description;

            _article.Update(article);

            _article.Save();

            return RedirectToAction("Index", "Home");
        
        
        }





        public IActionResult Delete(int? id)
        {
            Article article = _article.Get(i => i.Id == id);

            return View(article);
        }

        [HttpPost]
        public IActionResult Delete(Article article) { 
        
        
        _article.Remove(article);

            _article.Save();
        
        
        return RedirectToAction("Index","Home");
        
        
        }
    }
}
