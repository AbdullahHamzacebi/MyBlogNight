using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }
    }
}
/* 
 
1) Önce DataAccessLayer kısmından
    IArticleDalı yapıyoruz

2) DataAccess'den
   EntityFramework EfArticleDal

3) BusinessLayer'dan
   Abstract

4) BusinessLayer
   Concrete 

Bu şekilde dolduruyoruz.
 
 */