using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.Entitiy.Entities
{
    public class Article
    {
        public int Id { get; set; }

        public string Author { get; set; }
        public string Title { get; set; }
    
        public string Description { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; } = DateTime.Now;

        public int? userId { get; set; }

        public virtual AppUser? User { get; set; }

        public virtual List<Comment>? Comments { get; set; }



    }
}
