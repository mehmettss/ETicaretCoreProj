using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.ViewComponents.HomePageCategory
{
    public class HomePageCategoryList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             FeatureCategoryManager featureCategoryManager = new FeatureCategoryManager(new EfFeatureCategoryDal());
            var values = featureCategoryManager.GetList();
            return View(values);
        }
    }
}
