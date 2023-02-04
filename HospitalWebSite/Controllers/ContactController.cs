using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            var title = new SectionTitleModel()
            {
                Title = "Contact",
                ImageURL = "/images/contact.jpg"
            };
            return View(title);
        }
    }
}
