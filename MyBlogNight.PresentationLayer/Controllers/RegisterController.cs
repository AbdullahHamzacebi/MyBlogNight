using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Models;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            // bizim yerimize newleme işlemi yapıyor bizim için (dependency injection)
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Email = model.Email,
                Surname = model.Surname,
                UserName = model.Username,
                ImageUrl = "test"
                
            };
            var result = await _userManager.CreateAsync(appUser, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    //ModelState :  Formumuzdaki validasyonların doğru olup olmadığını ve eğer hata varsa onu kontrol ediyor.

                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
            
        }
    }
}

/*  Aplication Programming İnterface (API)
    Diyelim Yurtdışında bir yemek firmam var ve bunu ben veritabınını başka kişilerle paylaşmak için api'yi kullanırız.
    ActionResult'ın interface'si : IActionResult

    Senkron : Eş zamanlı olarak çalıştırabiliyorsun ve diğerini bekliyor. (Biri diğerini bekliyor. (Örnek olarak tek bir masa varsa tek bir garson varsa eğer garson 1 iş yapıyor ve müşterinin yemeğini bitmesini bekliyor.))
    Asenkron : Bunun dışında (Beklemek zorunda değil, Bloklamayan kod, (Ama burda garson gelip aşçıya söylediğinde aşçı yemeği yapıyor ve 2.yemeği yapıyor kısaca durmuyor ve garson onu engellemiyor.))

*/