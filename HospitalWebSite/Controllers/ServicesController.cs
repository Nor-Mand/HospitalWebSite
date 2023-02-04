using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            var title = new SectionTitleModel()
            {
                Title = "Services",
                ImageURL = "/images/services.jpg"
            };
            return View(title);
        }
    }
}
