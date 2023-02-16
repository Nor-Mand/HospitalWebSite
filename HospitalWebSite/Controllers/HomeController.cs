using HospitalWebSite.Models;
using HospitalWebSite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HospitalWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            GlobalIndexViewModel modelLink = new GlobalIndexViewModel();
            var respositoryDoctors = new RepositoryDoctors();
            var doctors = respositoryDoctors.GetDoctors().Take(6);

            var respositoryServices = new RepositoryServices();
            var services = respositoryServices.GetServices();
            
            modelLink.TypeServices = services;
            modelLink.Doctors = doctors;

            return View(modelLink);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}