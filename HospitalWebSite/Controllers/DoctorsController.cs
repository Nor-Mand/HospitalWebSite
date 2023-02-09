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
           GlobalIndexViewModel modelEnlace = new GlobalIndexViewModel();
            modelEnlace.Doctors = GetDoctors();
            modelEnlace.Titles = GetTitleDoctors();
            return View(modelEnlace);
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

        private List<SectionDoctorModel> GetDoctors()
        {
            return new List<SectionDoctorModel>
            {
                new SectionDoctorModel()
                {
                    Name= "Doctor 1",
                    Title = "Neurology",
                    ImageURL = "/images/doctor.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 2",
                    Title = "Neurology",
                    ImageURL = "/images/doctor.jpg"
                },
                new SectionDoctorModel() 
                {
                    Name= "Doctor 3",
                    Title = "Neurology",
                    ImageURL = "/images/doctor.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 4",
                    Title = "Neurology",
                    ImageURL = "/images/doctor.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 5",
                    Title = "Neurology",
                    ImageURL = "/images/doctor.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 6",
                    Title = "Neurology",
                    ImageURL = "/images/doctor.jpg"
                },
            };
        }
    }
}
