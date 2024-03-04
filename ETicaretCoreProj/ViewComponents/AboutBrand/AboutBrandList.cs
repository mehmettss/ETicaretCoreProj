using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.ViewComponents.AboutBrand
{
    public class AboutBrandList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AboutBrandManager aboutBrandManager = new AboutBrandManager(new EfAboutBrandDal());
            var values = aboutBrandManager.GetList();
            return View(values);
        }
    }
}
