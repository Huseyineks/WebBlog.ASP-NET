using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Entitiy.Entities;

namespace WebBlog.BusinessLogicLayer.Interface
{
    public interface IArticle : IRepository<Article>
    {
        void Update(Article article);

        void Save();
    }
}
