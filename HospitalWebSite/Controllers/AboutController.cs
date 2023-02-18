using HospitalWebSite.Models;
using HospitalWebSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace HospitalWebSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            GlobalIndexViewModel modelLink = new GlobalIndexViewModel();
            modelLink.Titles = GetTitlePage();

            var repositoryDoctors = new RepositoryDoctors();
            var doctors = repositoryDoctors.GetDoctors();
            modelLink.Doctors= doctors;

            return View(modelLink);
        }

        private List<SectionTitleModel> GetTitlePage()
        {
            return new List<SectionTitleModel>
            {
                new SectionTitleModel {
                    Title = "About us",
                    ImageURL = "/images/about.jpg"
                }
            };
        }
    }
}
