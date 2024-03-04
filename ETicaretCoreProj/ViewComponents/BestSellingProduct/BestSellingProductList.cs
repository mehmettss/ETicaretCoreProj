using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.ViewComponents.BestSellingProduct
{
    public class BestSellingProductList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BestSellingProductManager bestSellingProductManager = new BestSellingProductManager(new EfBestSellingProductDal());
            var values = bestSellingProductManager.GetList();
            return View(values);
        }
    }
}
