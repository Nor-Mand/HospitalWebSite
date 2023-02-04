using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            var title = new SectionTitleModel()
            {
                Title = "News",
                ImageURL = "/images/news.jpg"
            };
            return View(title);
        }
    }
}
