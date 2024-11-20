using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        // Başına T eklememizin sebebi bussiness metodlar ve dataacsess metodları karışmasın diye T koyduk ve data access de dal olarak adlandırılan kısımlar artık burda interface'ler servis kısmına dönüyor. Presentation katmanı bussines katmanına ulaşacak.
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        List<T> TGetAll();
        T TGetById(int id);

    }
}
