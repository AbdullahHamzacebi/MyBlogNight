using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        //2.olarak readonly eklediğimizde add parameters to seçmemiz gerekiyor ve ICategoryService categoryService bunları atıyor ekstra olarak

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public IActionResult ArticleList()
        {
            var values = _articleService.TArticleListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateArticle()
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> values1 =(from x in categoryList select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();
            ViewBag.v1 = values1;
            return View();
        }

        [HttpPost]
        public IActionResult CreateArticle(Article article)
        {
            article.CreatedDate = DateTime.Now;
            _articleService.TInsert(article);
            return RedirectToAction("ArticleList");
        }

        public IActionResult DeleteArticle(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("ArticleList");
        } 

        public IActionResult ArticleDetail(int id)
        {
            _articleService.TArticleViewCountIncrease(id);

            var value = _articleService.TArticleListWithCategoryAndAppUserByArticleId(id);
            return View(value);
        }
    }
}
/*
 
 
API projesinde 2 tane entity category ve product olacak ilişkisi olacak birlikte
bizden komple proje yapmamızı isteyecek hocamız ve 1 haftada bitirecek dersi 4 derste 

Rapid Api ye geçecez sonra bizden tekrardan proje isteyecek hocamız.(1 derste anlatacak hocamız 6.proje bitecek)


Dapper query bazlı çalışacaz 2 ders sürecek ve yine 1 tane proje

mongodb çalışacaz 

postsql çalışacaz

bunların hepsi proje 

json token çalışacaz sonra bunlar da bitecek (1 ders sürecek)

signalR çalışacaz (biraz uzun sürecek)

angular projesi

hepsine yönelik bir proje 

OnionArtitecture

mikroservis olacak (17-18 ders ve ağırlıklı backend projesi olacak.) (16-17 katmanlı olacak.)


 
 */ 