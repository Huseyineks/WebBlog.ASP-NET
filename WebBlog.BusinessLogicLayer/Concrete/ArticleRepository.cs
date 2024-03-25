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
    public class ArticleRepository : Repository<Article>, IArticle


    {
        ApplicationDbContext _db;
        public ArticleRepository(ApplicationDbContext db) : base(db) 
        {
        _db = db;
        
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Article article)
        {
            
            _db.Articles.Update(article);
        }
    }
}
