using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.EntityLayer.Concrete
{
    // indexleme yani google aramalarında üst sıralara çıkarmaya yarayan şey.
    // bir etiketin birden çok article'ı bir article'ın da birden çok etiketi olabilir.
    public class TagCloud 
    {
        public int TagCloudId { get; set; }
        public string Title { get; set; }

    }
}
