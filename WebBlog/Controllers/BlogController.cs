using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.Entitiy.Entities;

namespace WebBlog.Controllers
{
    public class BlogController : Controller
    {
        IValidator<RegisterationPost> _validator;
        IAppUser _appUser;
        IArticle _article;
        IComment _comment;

        public BlogController(IValidator<RegisterationPost> validator, IArticle article, IComment comment,IAppUser appUser)
        {
            _validator = validator;
            _article = article;
            _comment = comment;
            _appUser = appUser;
        }
        public IActionResult Register()
        {
        return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterationPost postUser) {

            var result = _validator.Validate(postUser);
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);

            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                AppUser newUser = new AppUser()
                {
                    firstName = postUser.firstName,
                    lastName = postUser.lastName,
                    email = postUser.email,
                    password = postUser.password,
                    createdAt = DateTime.Now
                };

                _appUser.Add(newUser);
                _appUser.Save();

                return RedirectToAction("Index", "Home");
            }
            
           



        
        
        }

        public IActionResult Login() { 
        
        return View();
        
        }

        [HttpPost]
        public IActionResult Login(AppUser currentUser)
        {

            return View();

        }
    }
}
