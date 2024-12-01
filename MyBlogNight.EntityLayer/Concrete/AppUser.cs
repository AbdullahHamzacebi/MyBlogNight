using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.EntityLayer.Concrete
{
    // bu işlem id kısmının int olmasını sağlıyor.
    public class AppUser : IdentityUser<int>  
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }


        /*  
            
            Update-database dediğimizde hata vermesinin sebebi içinde veri olmasından ve SQL'de veriyi silmek için kullanılan metod. 
            Truncate Table Articles (Articles içindeki verileri siler) bu metodu dedikten sonra update-database dediğimizde çalışır.

            onDelete: ReferentialAction.NoAction);
            migration yaptığımızda bu kısım gelmişti(mig12) 

            Diyelim 1 numaralı makeleyi listeden sildin.
            
            NoAction: silindiğinde herhangi bir şey yapılmaz 
            Cascade:  silinen makaleye ait yorumlar da siliniyor.
            SetNull : silinen makaleye ait yorumlar da null geliyor.

        */

    }
}
