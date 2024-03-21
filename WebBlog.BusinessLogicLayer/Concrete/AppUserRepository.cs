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
    public class AppUserRepository : Repository<AppUser>, IAppUser
    {
        private readonly ApplicationDbContext _db;
        public AppUserRepository(ApplicationDbContext db) : base(db) 
        { 
        
        _db = db;
        
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(AppUser appUser)
        {
            _db.AppUsers.Update(appUser);
        }

        List<Entitiy.Entities.AppUser> IRepository<Entitiy.Entities.AppUser>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
