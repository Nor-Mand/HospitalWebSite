using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            var title = new SectionTitleModel()
            {
                Title = "Doctors",
                ImageURL = "/images/doctors.jpg"
            };
            return View(title);
        }
    }
}
