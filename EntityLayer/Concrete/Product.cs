using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
      
        public string Name { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public int Rate { get; set; }
        public string Size { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string ImageUrl4 { get; set; }

        public decimal Price { get; set; }
        public int StockQuantity { get; set; }


        // Ürünün hangi kategoriye ait olduğunu belirtir
        public int CategoryId { get; set; }

        // Kategoriye referans
        public Category Category { get; set; }
        public ICollection<Cart> Carts { get; set; }
       
    }
}
