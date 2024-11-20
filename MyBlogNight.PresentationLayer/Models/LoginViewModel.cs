namespace MyBlogNight.PresentationLayer.Models
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

/* 
  
   viewmodel ile dto arasında nasıl fark var ?
   dto daha kapsamlı
   viewmodel entity'e özgü olarak kullanılıyor. Fakat dto arada farklı bir katman olduğu için daha kapsamlı oluyor.


     public async Task<IActionResult> Index(AppUser)
     {

     }

    LoginController içindeki kısımda neden AppUser'dan örnek almadık da ViewModel kullandık? 
        
    Bize sadece 2 tane prop lazım o yüzden.

*/