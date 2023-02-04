using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
