using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string Code { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } // Yüzde veya sabit miktar
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
