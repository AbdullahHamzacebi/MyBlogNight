using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _DefaultSocialMediaComponentPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetAll();
            return View(values);
        }

    }
}
/* 
 
 ViewComponent ne işe yarar ? 
 Partialview'ın yenilenmiş hali diyebiliriz .net core'daki.

 View Component, PartialView ve Controller Action'larının bir karışımıdır ve MVC framework'ü içinde kullanılır. View Component'lar, PartialView'lar gibi parçalı görünümler içerebilir ve Controller Action'ları gibi veri döndürebilir.




 */ 