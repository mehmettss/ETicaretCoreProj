using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BestSellingProduct
    {
        public int BestSellingProductId { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rate  { get; set; }
    }
}
