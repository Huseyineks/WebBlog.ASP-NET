﻿
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

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppUser>().HasData(

              
              
               new AppUser { Id = 1, firstName = "sa", lastName = "Turker1231", createdAt = DateTime.Now, email = "erhan",password = "serdar" },

               

                new AppUser {Id = 2,firstName = "as", lastName = "Turker", createdAt = DateTime.Now , email = "erhan", password = "serdar12312" }

                );


            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(i => i.Id).HasColumnName("id").UseIdentityColumn().IsRequired();
                entity.Property(i => i.email).HasColumnName("email");
                entity.Property(i => i.firstName).HasColumnName("first_name");
                entity.Property(i => i.lastName).HasColumnName("last_name");
                entity.Property(i => i.password).HasColumnName("password");
            });
            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(i => i.Id).UseIdentityColumn().HasColumnName("id").IsRequired();
                entity.Property(i => i.Title).HasColumnName("title");
                entity.Property(i => i.Description).HasColumnName("description");
                entity.HasOne(i => i.User).WithMany(i => i.Articles).HasForeignKey(i => i.userId).OnDelete(DeleteBehavior.SetNull);
            
            });
            modelBuilder.Entity<Comment>(entity =>
            {

                entity.Property(i => i.Id).HasColumnName("id").UseIdentityColumn().IsRequired(); 
                entity.Property(i => i.commmentDescription).HasColumnName("comment");
                entity.HasOne(i => i.article).WithMany(i => i.Comments).HasForeignKey(i => i.articleId).OnDelete(DeleteBehavior.SetNull);
                entity.HasOne(i => i.User).WithMany(i => i.Comments).HasForeignKey(i => i.userId).OnDelete(DeleteBehavior.SetNull);
               

            });

            modelBuilder.Entity<Article>().HasData(

               

                new Article {Id =2, userId = 1, Title = "sa123", Description = "akjsdnkjasashkjd", createdAt = DateTime.Now,Author = "erhan",Image = "sa" },

                new Article {Id = 3, userId = 1, Title = "sa123", Description = "akjsdnkjasashkjd", createdAt = DateTime.Now, Author = "erhan", Image = "as" },

                 new Article { Id = 4, userId = 2, Title = "sa123", Description = "akjsdnkjasashkjd", createdAt = DateTime.Now, Author = "erhan", Image = "sa" }

                );
        }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
