using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.EntityLayer.Concrete
{
    
    public class Category
    {
        public int CategoryId { get; set; }

       // [Required(ErrorMessage ="hata mesajı")]  // bu kullanım solid'i eziyor neden? bu sınıfın sadece entityleri tanımlanmalı.Eğer hata mesajı gibi bir şey eklersek 2 şeye hizmet etmiş olacak.(propları tutacak hem de annotationsları tutacak.Onun için solid'i eziyor. Solid'in s sini eziyor. Single responsibility =tek sorumluluk ilkesini eziyor. 1 metod 1 iş yapmalı gibisinden.)
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
