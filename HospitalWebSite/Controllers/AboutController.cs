using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace HospitalWebSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var title = new SectionTitleModel()
            {
                Title = "About",
                ImageURL = "/images/about.jpg"
            };
            return View(title);
        }
    }
}
