using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
