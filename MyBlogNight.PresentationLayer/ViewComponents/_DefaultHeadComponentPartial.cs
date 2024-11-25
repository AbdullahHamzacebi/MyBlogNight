using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            // Invoke : Çağırmak
            return View();
        }
    }
}
/*  
 
    ViewComponent diye klasör açtık onun mantığı Partialview lara bir çeşit altarnatif.
    Partial url üzerinden ulaşabiliyoruz ama viewcomponentlere ulaşamıyoruz. bu da daha güvenli hale getiriyor. Controllerdaki yükleri de biraz azaltıyor.
 
 */