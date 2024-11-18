using MyBlogNight.DataAccessLayer.Abstarct;
using MyBlogNight.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.Repositories
{
    // interface interface'i miras alır.
    // Ama burda bir class interface'i miras alıyor.
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        // private : sadece bu sınıfta erişebilir
        // readonly : sadece okunabilir. 
        // private readonly : sadece bu sınıftan okunabilir anlamında.

        // nesne oluşturmak için mesela örnekteki gibi (private readonly BlogContext _context;  new'lerim. O sayede yapıcı metod oluşur.)
        // yapıcı metod : bir sınıf çağırıldığında ilk olarak çalışan yer.

        private readonly BlogContext _context;

        public GenericRepository(BlogContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            // altın yeşil çizgisi null gelebilir o yüzden.
            return _context.Set<T>().Find(id); 
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
