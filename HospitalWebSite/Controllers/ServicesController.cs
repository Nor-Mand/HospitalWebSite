using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
