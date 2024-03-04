using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.ViewComponents.ShopNavbar
{
    public class ShopNavbarList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
