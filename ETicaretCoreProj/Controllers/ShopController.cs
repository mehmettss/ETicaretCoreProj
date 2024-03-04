using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;

namespace ETicaretCoreProj.Controllers
{
    public class ShopController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        CartManager cartManager = new CartManager(new EfCartDal());
        Context context = new Context();
        [HttpGet]
        public IActionResult Index(int page=1)
        {
          
         
            var values = productManager.GetList().ToPagedList(page,9);
         
            return View(values);
        }
        public IActionResult AddCart(int id)
        {
            Cart cart = new Cart();
            int userId = 1;
            //var values = productManager.GetById(id);

          
            cart.UserId=userId;

        
            
            cart.ProductId = id;
            cartManager.TAdd(cart);
            return RedirectToAction("index");
        }

        public ActionResult ProductDetail(int id)
        {
            var valu=productManager.GetById(id);
            return View(valu);
        }



        public IActionResult FilterKosu(int s = 1)
        {
    
            var values = context.Products.FromSql($"exec GetProductsByCategoryId @categoryId=2").ToList().ToPagedList(s, 6);
            return View(values);
        }
        public IActionResult FilterYuruyus(int s2 = 1)
        {
         
            var values = context.Products.FromSql($"exec GetProductsByCategoryId @categoryId=6").ToList().ToPagedList(s2, 6);
            return View(values);
        }
        public IActionResult FilterSandalet(int s3 = 1)
        {

            var values = context.Products.FromSql($"exec GetProductsByCategoryId @categoryId=5").ToList().ToPagedList(s3, 6);
            return View(values);
        }
        public IActionResult FilterFutbol(int s4 = 1)
        {

            var values = context.Products.FromSql($"exec GetProductsByCategoryId @categoryId=3").ToList().ToPagedList(s4, 6);
            return View(values);
        }
        public IActionResult FilterBot(int s5 = 1)
        {

            var values = context.Products.FromSql($"exec GetProductsByCategoryId @categoryId=4").ToList().ToPagedList(s5, 6);
            return View(values);
        }
        public IActionResult FilterErkek(int s6 = 1)
        {

            var values = context.Products.FromSql($"exec GetProductsByGender @Gender='Erkek'").ToList().ToPagedList(s6, 6);
            return View(values);
        }
        public IActionResult FilterKadin(int s7 = 1)
        {

            var values = context.Products.FromSql($"exec GetProductsByGender @Gender='Kadın'").ToList().ToPagedList(s7, 6);
            return View(values);
        }
        public IActionResult FilterUnisex(int s8 = 1)
        {

            var values = context.Products.FromSql($"exec GetProductsByGender @Gender='Unisex'").ToList().ToPagedList(s8, 6);
            return View(values);
        }

    }
}
