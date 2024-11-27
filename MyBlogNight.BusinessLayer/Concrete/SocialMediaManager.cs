using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Abstarct;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal; // ISocialMediaDal dataAccess te yer alıyor.

        // Constructor (yapıcı metot) : Nesne oluşturulduğunda ilk çalışan kısım. (ilgili sınıf çağırıldığında bizim elimize nesne örneği oluşuyordu.)
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TDelete(int id)
        {
           _socialMediaDal.Delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMediaDal.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
           _socialMediaDal.Update(entity);
        }
    }
}
/* 
 
 ISocialMediaDal dataAccess'de yer alıyor.

 Constructor (yapıcı metot) : Nesne oluşturulduğunda ilk çalışan kısım. (ilgili sınıf çağırıldığında bizim elimize nesne örneği oluşuyordu.)
 
    ViewComponent ne işe yarar ? 
    Partialview'ın yenilenmiş hali diyebiliriz .net core'daki.

    View Component, PartialView ve Controller Action'larının bir karışımıdır ve MVC framework'ü içinde kullanılır. View Component'lar, PartialView'lar gibi parçalı görünümler içerebilir ve Controller Action'ları gibi veri döndürebilir.


 
 */ 