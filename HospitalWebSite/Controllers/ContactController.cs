using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            GlobalIndexViewModel modelEnlace = new GlobalIndexViewModel();
            modelEnlace.Titles = GetTitlePage();
            return View(modelEnlace);
        }

        private List<SectionTitleModel> GetTitlePage()
        {
            return new List<SectionTitleModel>
            {
                new SectionTitleModel {
                    Title = "Contact",
                    ImageURL = "/images/contact.jpg"
                }
            };
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel ContactViewModel) 
        {
            return Redirect("Home/Index");
        }
    }
}
