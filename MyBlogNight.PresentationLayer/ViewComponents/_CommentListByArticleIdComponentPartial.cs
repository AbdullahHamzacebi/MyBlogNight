using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _CommentListByArticleIdComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListByArticleIdComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke()
        {
            var values =  _commentService.TGetCommentsByArticleId(3);
            return View(values);  
        }
    }
}

/* 
 
 yorum listesinde GetById işimize yaramaz neden ? 
 
 tek 1 yorumu getirir yani article ıd yi getirir.
 
 
 */ 