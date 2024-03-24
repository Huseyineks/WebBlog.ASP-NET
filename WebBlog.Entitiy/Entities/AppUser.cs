using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.Entitiy.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        public string? email { get; set; }
        public string password { get; set; }
        public DateTime createdAt { get; set; }

        // relational 

        public virtual List<Article>? Articles { get; set; }

        public virtual List<Comment>? Comments { get; set; }


    }
}
