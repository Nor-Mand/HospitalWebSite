﻿using Microsoft.AspNetCore.Mvc;

namespace HospitalWebSite.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
