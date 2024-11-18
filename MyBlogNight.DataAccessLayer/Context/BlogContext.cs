using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.Context
{
    public class BlogContext : IdentityDbContext<AppUser,AppRole,int>
    {
        //override : bir metodun benim istediğim tarzda kullanımı anlamına geliyor.OnConfiguring(veritabanını bağlantını sağlar.)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HMC;initial catalog=BlogFoodyDb;integrated security=true");
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
    }
}

/* 
 
 Sql de Identity yaptığımızda gelen AspNetUsers kısmındaki açıklamalar;

Id	                        nvarchar(450)	(id illaki int olmak zorunda değil string de olabilir.)
UserName	                nvarchar(256)	(kullanıcı adı)
NormalizedUserName	        nvarchar(256)	(Büyük harfle yazılır ve karakter sorunu olmasın diye özellikle indexlemede(sql'de) kullanılır.İndexleme : kullanıcı adın var ve veri tabanında aranması gerekiyor diyelim ve pencere kelimesinin ingilizcesi için diyelim p harfine arattığımızda direk bulması açısından (search) )
Email	                    nvarchar(256)	(Email)
NormalizedEmail 	        nvarchar(256)	(Email'in büyük harfle kullanılması)
EmailConfirmed	            bit	Unchecked   (Email ile kod gönderilir ve doğrulama kodu gibi.)
PasswordHash	            nvarchar(MAX)	(Şifrenin hashlenmiş yani(şifrelenmiş hali))
SecurityStamp	            nvarchar(MAX)	
ConcurrencyStamp	        nvarchar(MAX)	
PhoneNumber     	        nvarchar(MAX)	(phone number)
PhoneNumberConfirmed	    bit	Unchecked   (phone number'ın onaylanması)
TwoFactorEnabled	        bit	Unchecked   (2 adımda doğrulama)
LockoutEnd	                datetimeoffset(7)   (giriş engelleme için kullanılır.)
LockoutEnabled	            bit	Unchecked    (programlamada her bir yanlış girdiğinde bu sayılsın mı diye kullanılır.)
AccessFailedCount	        int	Unchecked    
 

Identity kısmını sildiğimizde ve DbContext kaldığında  tekrardan mig4 ekledik ve update-database yaptık identity gitti 
 
 
 */
