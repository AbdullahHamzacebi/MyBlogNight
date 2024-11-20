namespace MyBlogNight.PresentationLayer.Models
{
    public class RegisterViewModel
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        
    }
}
/* 
 
 
    RegisterController içerisinde
 
        [HttpPost]
        public async Task<IActionResult> Index(AppUser)
        {
            return View();
        }

    Neden AppUser kullanmadık da burda RegisterViewModel oluşturduk ?
    
    Çünkü; Fazla alan kaplamasın diye yaptık. AppUser da çok fazla alan var.



    AppUser'da

    Bir register işleminde kullanıcıya yönelik ALMAMAMIZ GEREKEN şeyler nedir ?
    
    Fotoğrafı, ne zaman kayıt olduğu, TwoFactorEnabled , NormalizedUserName , NormalizedEmail. Bunları almak ZORUNDA DEĞİLİZ.
 
 */ 