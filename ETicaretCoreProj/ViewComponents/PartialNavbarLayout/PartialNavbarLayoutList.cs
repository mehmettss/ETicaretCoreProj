using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace ETicaretCoreProj.ViewComponents.PartialNavbarLayout
{
    public class PartialNavbarLayoutList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());
            //CartManager cartManager = new CartManager(new EfCartDal());
            Context context = new Context();



            //var user1Carts=context.Carts.Where(x=>x.UserId == 1).Select(y=>y.ProductId).ToList();


            //var values = context.Products.FromSql($"EXEC GetProductNamesByProductIds @user1Carts").ToList();






            //return View(values);
            var user1Carts = context.Carts
                               .Where(cart => cart.UserId == 1)
                               .Select(cart => cart.ProductId)
                               .ToList();

            // Bu ID'lerle ilişkili ürünleri çek
            var values = context.Products
                                .Where(product => user1Carts.Contains(product.ProductId))
                                .ToList();
            int count=values.Count();
            ViewBag.cartCount = count;

            return View(values);
        }
    }
}
