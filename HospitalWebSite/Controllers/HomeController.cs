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
            var respositoryServices = new RepositoryServices();
            var services = respositoryServices.GetServices();
            var modelo = new GlobalIndexViewModel() { TypeServices = services };
            return View(modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}