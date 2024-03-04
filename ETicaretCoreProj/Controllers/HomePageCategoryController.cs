using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.Controllers
{
    public class HomePageCategoryController : Controller
    {
        FeatureCategoryManager FeatureCategoryManager = new FeatureCategoryManager(new EfFeatureCategoryDal());
        public PartialViewResult FeatureCategoryPartial()
        {
            var values = FeatureCategoryManager.GetList();
            return PartialView(values);
        }
    }
}
