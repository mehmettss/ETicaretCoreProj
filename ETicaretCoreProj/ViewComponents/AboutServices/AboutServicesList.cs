using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.ViewComponents.AboutServices
{
    public class AboutServicesList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AboutServiceManager aboutServiceManager = new AboutServiceManager(new EfAboutServiceDal());
            var values = aboutServiceManager.GetList();
            return View(values);
        }
    }
}
