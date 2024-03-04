using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; } // Ebeveyn kategorinin ID'si

        // Ebeveyn kategoriye referans
        public ParentCategory ParentCategory { get; set; }

        public List<Product> Products { get; set; } // Kategoriye ait ürünlerin listesi
    }
}
