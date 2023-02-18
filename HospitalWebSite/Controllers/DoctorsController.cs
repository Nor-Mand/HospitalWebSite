using HospitalWebSite.Models;
using HospitalWebSite.Services;
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

            var repositoryDoctors = new RepositoryDoctors();
            var doctors = repositoryDoctors.GetDoctors();
            modelLink.Doctors = doctors;
            return View(modelLink);
        }

        private List<SectionTitleModel> GetTitleDoctors()
        {
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
