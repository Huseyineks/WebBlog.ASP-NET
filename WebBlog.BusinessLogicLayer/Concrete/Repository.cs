using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebBlog.BusinessLogicLayer.Interface;
using WebBlog.DataAccesLayer.Data;

namespace WebBlog.BusinessLogicLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)  {
            
            _db = db;

            this.dbSet = _db.Set<T>();
        
        }
        public void Add(T item)
        {
            dbSet.Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            dbSet.AddRange(items);
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            
            IQueryable<T> query = dbSet.Where(filter);

            
                return query.FirstOrDefault();
            
   

            
        }
        public IQueryable<T> GetClassifiedList(Expression<Func<T, bool>> filter)
        {

            IQueryable<T> query = dbSet.Where(filter);


            return query;

        }

        public void Remove(T item)
        {
            dbSet.Remove(item);
        }

        public void RemoveRange(List<T> list)
        {
            dbSet.RemoveRange(list);
        }

 

        public void RemoveRange(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
