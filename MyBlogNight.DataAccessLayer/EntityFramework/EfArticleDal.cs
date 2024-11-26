﻿using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccessLayer.Abstarct;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }

        public List<Article> ArticleListWithCategory()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;

            //include = ilişkisel tablo arasındaki bağlantıyı sağlıyor.
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new BlogContext();
            var values = context.Articles.Include(x =>x.Category).Include(y => y.AppUser).ToList();
            return values;
        }
    }
}
