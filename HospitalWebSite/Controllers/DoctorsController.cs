using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace HospitalWebSite.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
           GlobalIndexViewModel modelLink = new GlobalIndexViewModel();
            modelLink.Titles = GetTitleDoctors();
            return View(modelLink);
        }

        private List<SectionTitleModel> GetTitleDoctors() {
            return new List<SectionTitleModel>
            {
                new SectionTitleModel {
                    Title = "Doctors",
                    ImageURL = "/images/doctors.jpg"
                } 
            };
        }
    }
}
