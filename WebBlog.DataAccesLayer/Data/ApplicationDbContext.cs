using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBlog.Entitiy.Entities;

namespace WebBlog.DataAccesLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Comment>  Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(i => i.Id).HasColumnName("id").UseIdentityColumn();
                entity.Property(i => i.email).HasColumnName("email");
                entity.Property(i => i.firstName).HasColumnName("first_name");
                entity.Property(i => i.lastName).HasColumnName("last_name");
            });
            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(i => i.Id).UseIdentityColumn().HasColumnName("id");
                entity.Property(i => i.Title).HasColumnName("title");
                entity.Property(i => i.Description).HasColumnName("description");
                entity.HasOne(i => i.User).WithMany(i => i.Articles).HasForeignKey(i => i.userId).OnDelete(DeleteBehavior.Restrict);
                
            });
            modelBuilder.Entity<Comment>(entity =>
            {

                entity.Property(i => i.Id).HasColumnName("id").UseIdentityColumn();
                entity.Property(i => i.commmentDescription).HasColumnName("comment");
                entity.HasOne(i => i.article).WithMany(i => i.Comments).HasForeignKey(i => i.articleId).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(i => i.User).WithMany(i => i.Comments).HasForeignKey(i => i.userId).OnDelete(DeleteBehavior.Restrict);

            });
        }
    }
}
