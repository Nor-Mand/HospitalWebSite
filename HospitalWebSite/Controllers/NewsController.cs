using HospitalWebSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class NewsController : Controller
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
                    Title = "News",
                    ImageURL = "/images/news.jpg"
                }
            };
        }
    }
}
