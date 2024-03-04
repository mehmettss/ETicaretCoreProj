using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; } // Bir siparişin bir kullanıcısı olmalıdır.

        public DateTime OrderDate { get; set; }
        public string PaymentInfo { get; set; }
        public string ShippingInfo { get; set; }

        // Bir siparişin bir kullanıcısı olmalıdır.
        public User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}

