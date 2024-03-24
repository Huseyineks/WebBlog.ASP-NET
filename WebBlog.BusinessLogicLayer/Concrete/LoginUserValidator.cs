using FluentValidation;
using FluentValidation.Validators;
using ServiceStack.FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.Entitiy.Entities;

namespace WebBlog.BusinessLogicLayer.Concrete
{

    public class LoginUserValidator : AbstractValidator<AppUser>
    {
        IAppUser _user;
        public LoginUserValidator(IAppUser user)
        {

            _user = user;
            RuleFor(i => i.password).Custom((password, context) => BeValidUser(context.InstanceToValidate.firstName, context.InstanceToValidate.lastName, password, context));

            

        }



        private void BeValidUser(string firstName, string lastName, string password, ValidationContext<AppUser> context)
        {

            var User = _user.Get(i => i.password == password);

            if (User == null)
            {

               if(password  == null)
                {
                    return;
                }
                else
                {
                    context.AddFailure("Wrong Password");
                }

            }
            else
            {

                if (User.firstName == firstName && User.lastName == lastName)
                {
                    return;

                }
                else if (User.firstName == firstName && User.lastName != lastName)
                {


                    context.AddFailure("Last Name is not valid.");


                }
                else if (User.firstName != firstName && User.lastName == lastName)
                {

                    context.AddFailure("First Name is not valid");
                }
                else
                {
                    context.AddFailure("Invalid firstname and lastname");
                }



            }



        }










    }
}