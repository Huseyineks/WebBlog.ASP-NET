using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.Entitiy.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string commmentDescription { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; } = DateTime.Now;
        public int? userId { get; set; }

        public int? articleId { get; set; }

        public virtual AppUser? User { get; set; }

        public virtual Article? article { get; set; }

        


    }
}
