using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

// MVC proje kampı 
// Udemy .net core adım adım web geliştirme
// Asp.net core portfolyo 1
// Asp.net core portfolyo 2