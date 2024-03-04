using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // Kullanıcının birden çok siparişi olabilir, bu nedenle List<Order> kullanıyoruz.
        public List<Order> Orders { get; set; }
         public List<Comment> Comments { get; set; }
        //public List<Cart> Carts { get; set; }

    }

}
