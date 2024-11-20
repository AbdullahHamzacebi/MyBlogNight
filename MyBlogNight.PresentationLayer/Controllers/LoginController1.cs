using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class LoginController1 : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController1(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
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