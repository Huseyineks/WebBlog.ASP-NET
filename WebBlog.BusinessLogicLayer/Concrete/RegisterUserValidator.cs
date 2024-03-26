using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.BusinessLogicLayer.Model.DTOs;
using WebBlog.Entitiy.Entities;

namespace WebBlog.BusinessLogicLayer.Concrete
{
   
        public class RegisterUserValidator : AbstractValidator<RegisterDTO>
        {
            IAppUser _appUser;
            public RegisterUserValidator(IAppUser user)
            {
            _appUser = user;

            RuleFor(x => x.email).EmailAddress().WithMessage("Please enter a valid email!").Must(uniqueEmailAdress).WithMessage("Email is used.");
            RuleFor(x => x.firstName).MaximumLength(50).WithMessage("Name is so long. Please enter shorter.").Must(uniqueFirstName).WithMessage("Firstname is used.");
            RuleFor(x => x.lastName).MaximumLength(50).WithMessage("Last name is so long. Please enter shorter.").Must(uniqueLastName).WithMessage("Lastname is used.");
            RuleFor(x => x.password).Equal(x => x.confirmPassword).WithMessage("Passwords don't match").Must(uniquePassword).WithMessage("Password is used");

                

        }
        private bool uniquePassword(string password)
        {
            var User = _appUser.Get(x => x.password == password);
            
            if (User == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool uniqueFirstName(string firsName)
        {
            var User = _appUser.Get(x => x.firstName == firsName);

            if (User == null)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private bool uniqueLastName(string lastName)
        {

            var User = _appUser.Get(x => x.lastName == lastName);

            if (User == null)
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        private bool uniqueEmailAdress(string email)
        {
            var User = _appUser.Get(i => i.email == email);

            if (User == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        }
      
    }
    

