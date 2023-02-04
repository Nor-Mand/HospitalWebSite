using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
