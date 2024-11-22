using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.EntityLayer.Concrete
{
    
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Article> Articles { get; set; }

    }
}

/* 
  
 public-private-interval-protected

 public : Herkese açık olan
 
 private : Sadece kendi içinde bulunduğu kısımdan erişim sağlıyor.
 
 interval : Sadece bulunduğu katman içinde erişim sağlayan

 protected : Bulunduğu sınıf ve o sınıfın miras aldığı sınıflardan erişim sağlıyor.
 
 */
