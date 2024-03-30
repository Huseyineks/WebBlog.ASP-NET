using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.BusinessLogicLayer.Model.DTOs;
using WebBlog.Entitiy.Entities;

namespace WebBlog.Controllers
{
    public class BlogController : Controller
    {
        IValidator<RegisterDTO> _validator;
        IAppUser _appUser;
        IArticle _article;
        IComment _comment;
        IValidator<AppUserDTO> _validatorL;
        
        
        

        public BlogController(IValidator<RegisterDTO> validator, IArticle article, IComment comment,IAppUser appUser, IValidator<AppUserDTO> validatorL)
        {
            _validator = validator;
            _article = article;
            _comment = comment;
            _appUser = appUser;
            _validatorL = validatorL;
            
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
        return View();
        }


        [AllowAnonymous]
        [HttpPost]
        
        public async Task<IActionResult> Register(RegisterDTO postUser) {

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

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier,newUser.Id.ToString()),
                    new Claim(ClaimTypes.Name, newUser.firstName + ' ' + newUser.lastName),
                    new Claim(ClaimTypes.Email,newUser.email),
                    new Claim(ClaimTypes.DateOfBirth,newUser.createdAt.ToString())


                };

                var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }
            
           



        
        
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login() { 
        
        return View();
        
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(AppUserDTO currentUser)
        {

            var result = _validatorL.Validate(currentUser);

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.ErrorMessage);
            }

            if (!ModelState.IsValid)
            {

                return View();

            }

            AppUser user = _appUser.Get(i => i.password == currentUser.password);

            
           
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.firstName + ' ' + user.lastName),
                    new Claim(ClaimTypes.Email,user.email),
                    new Claim(ClaimTypes.DateOfBirth,user.createdAt.ToString())
                    
                };

                var userIdentity = new ClaimsIdentity(claims,"Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            


            

        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Blog");
        }
    }
}
