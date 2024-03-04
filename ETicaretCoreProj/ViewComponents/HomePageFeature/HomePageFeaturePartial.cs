using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.ViewComponents.HomePageFeature
{
    public class HomePageFeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            HomePageFeatureManager homePageFeatureManager = new HomePageFeatureManager(new EfHomePageFeatureDal());
            var values = homePageFeatureManager.GetList();
            return View(values);
        }
    }
}
