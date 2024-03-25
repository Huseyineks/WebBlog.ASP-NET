using Microsoft.AspNetCore.Mvc;
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
        

        public ArticleController(IArticle article) { 
        
        _article = article;
        

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
            string FullName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value.ToString();
            _article.Add(
                
                new Article()
                {
                    Id = article.ID,
                    Author = FullName,
                    Title = article.Title,
                    Description = article.Description,
                    createdAt = DateTime.Now,
                    userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToInt()
        }
                
                
                );
            _article.Save();



            return RedirectToAction("Index","Home");
        }
        public IActionResult Details(int ?id) {

            Article article = _article.Get(i => i.Id == id);


            return View(article);
        
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
