using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        // ActionResult'ın interface'si : IActionResult
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

// Aplication Programming İnterface (API)
// Diyelim Yurtdışında bir yemek firmam var ve bunu ben veritabınını başka kişilerle paylaşmak için api'yi kullanırız.