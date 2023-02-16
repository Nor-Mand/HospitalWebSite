using HospitalWebSite.Models;
using HospitalWebSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace HospitalWebSite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            GlobalIndexViewModel modelEnlace = new GlobalIndexViewModel();
            modelEnlace.Titles = GetTitlePage();
            var respositoryServices = new RepositoryServices();
            var services = respositoryServices.GetServices();
            modelEnlace.TypeServices = services;
            return View(modelEnlace);
        }

        private List<SectionTitleModel> GetTitlePage()
        {
            return new List<SectionTitleModel>
            {
                new SectionTitleModel {
                    Title = "Services",
                    ImageURL = "/images/services.jpg"
                }
            };
        }

    }
}
