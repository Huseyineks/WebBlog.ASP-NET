using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Entitiy.Entities;

namespace WebBlog.BusinessLogicLayer.Concrete
{
   
        public class AppUserValidator : AbstractValidator<RegisterationPost>
        {

            public AppUserValidator()
            {

                RuleFor(x => x.email).EmailAddress().WithMessage("Please enter a valid email!");
                RuleFor(x => x.firstName).MaximumLength(50).WithMessage("Name is so long. Please enter shorter.");
                RuleFor(x => x.lastName).MaximumLength(50).WithMessage("Last name is so long. Please enter shorter.");
                RuleFor(x => x.password).Equal(x => x.confirmPassword).WithMessage("Passwords don't match");

                

        }


        }
    }

