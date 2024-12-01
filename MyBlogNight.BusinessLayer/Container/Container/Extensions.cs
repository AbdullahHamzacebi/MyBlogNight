using Microsoft.Extensions.DependencyInjection;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.BusinessLayer.Concrete;
using MyBlogNight.DataAccessLayer.Abstarct;
using MyBlogNight.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Container.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies( this IServiceCollection services)
        {
            /*   
                
                 this anahtar sözcüğü nedir?
                 this olmazsa ne olur ? 
                
                program.cs deki;
                aynı türden oluşturup onun da orda kullanımını sağlayabiliyoruz.
                
                builder.Services.ContainerDependencies();

                
            */

            services.AddScoped<IArticleDal, EfArticleDal>();
            services.AddScoped<IArticleService, ArticleManager>();

            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();

            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();
        }
    }
}
/* 
 
 static nedir ? 

( field,prop,method,constructor ) veya sınıfı belirlemek için kullanılır. Static olarak tanımlanan üyeler veya sınıflar, nesneye özel değil doğrudan sınıfa     bağlıdır. Bu bir instance (new) oluşturmadan erişim sağlayabileceğiniz anlammına gelir.
    Dependency Injection ile kullanılmaz. 


 */ 