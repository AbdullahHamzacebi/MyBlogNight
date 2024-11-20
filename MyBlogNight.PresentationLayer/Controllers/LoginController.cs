using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Models;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            // asyn metodu kullanmak için arada başka bir yapıyı beraber kullanmak için kullandığım metod (await)
            // lockoutOnFailure : her bir yanlış giriş sayısını sayması.
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password,false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Category");
            }
            else
            {
                return View();
            }
        }
    }
}

/* 

 Bunları kesin bitir.
 
 50 Derste MVC
 50 Derste Tatil Seyahat Sitesi
 Mvc5 Admin Panelli Cv Sitesi
 Mvc Proje Kampı(25 saat)
 AspNet Core ile Adım Adım Web Geliştirme

 */

/*  Register'ı kullanana UserManager'dı 
    Login işlemlerini de kullanan SignInManager 


1-2. projeleri bitir
youtube ve udemy den 1-1 proje bitir.

daha .net core görmedik.
tasarımda bir kaç yer gösterecek hoca

eğitimin kalan derslerinde tasarım görmeyecez 
tema atacak hoca onu biz düzenleyecez.

son tema çalışması bu projede olacak.
bu projenin admin panelinde tema çalışmayacak hoca uı tarafını birlikte yapacaz.(blokların listelenmesi, yorumların gelmesi gibi konu başlıkları. ) kalan kısımlar bizde komple 

4. proje ıdentity projesi olacak şu anda anlattığı kısım.

ıdentity ile 1 tane case verecek bize o case e mail mesajlaşma uygulaması olacak detaylarını bizimle paylaşacak

5.API projesi olacak ve 
 navbar, crud işlemleri  
 n katmanlı mimari olacak.
 api anlatırken product, customer sipariş ,customer olacak.bizden proje isteyecek

6.rapidApi olacak projesi booking, ets tur projesi olacak

7.uygulamadaki 2.tasarım modeli olacak ve chanofrespontibility

8.dapper

9.mongodb

10.postsql

11.dizayn patent 

12.onion artic.

13.json

14.signal R

15.Angular

16.Microservice


1) Yapacağımız projeler 
  
 DbFirst (Tamamlandı)
 CodeFirst
 AspNet Core N tier arc.
 Identity
 Api
 Rapid Api
 Chain of Resp. (Design Pat)
 CQER & Mediator
 Mongo Db
 PostreSQL
 Onion Arc.
 Jwt (Spotify)
 Ajax - Jquery
 SignalR
 Dapper
 Mikroservis
 Redis 
 ElasticSearch
 IdentityModel


*/