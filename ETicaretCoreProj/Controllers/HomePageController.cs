using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretCoreProj.Controllers
{

    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
