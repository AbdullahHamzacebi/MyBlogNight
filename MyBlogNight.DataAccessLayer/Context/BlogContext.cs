using Microsoft.EntityFrameworkCore;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.Context
{
    public class BlogContext : DbContext
    {
        //override : bir metodun benim istediğim tarzda kullanımı anlamına geliyor.OnConfiguring(veritabanını bağlantını sağlar.)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HMC;initial catalog=BlogFoodyDb;integrated security=true");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
    }
}
