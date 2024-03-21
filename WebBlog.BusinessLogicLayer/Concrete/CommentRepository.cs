using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.DataAccesLayer.Data;
using WebBlog.Entitiy.Entities;

namespace WebBlog.BusinessLogicLayer.Concrete
{
    public class CommentRepository : Repository<Comment>, IComment
    {
        ApplicationDbContext _db;
        public CommentRepository(ApplicationDbContext db) : base(db)
         { 
           
            _db = db;
           
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Comment comment)
        {
            _db.Comments.Update(comment);
        }
    }
}
