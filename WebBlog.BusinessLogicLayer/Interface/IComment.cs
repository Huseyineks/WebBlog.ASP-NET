using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Entitiy.Entities;

namespace WebBlog.BusinessLogicLayer.Interface
{
    public interface IComment : IRepository<Comment>
    {
        void Update(Comment comment);

        void Save();
    }
}
