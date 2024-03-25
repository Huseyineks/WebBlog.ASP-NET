using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.BusinessLogicLayer.Interface
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T,bool>> filter);
        
        List<T> GetAll();

        void Remove(T item);

        void RemoveRange(int start,int end);

        void Add(T item);

        void AddRange(IEnumerable<T> items);

        IQueryable<T> GetClassifiedList(Expression<Func<T, bool>> filter);
    }
}
