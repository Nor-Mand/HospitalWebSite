using HospitalWebSite.Models;

namespace HospitalWebSite.Services
{
    public class RepositoryServices
    {
        public List<ServicesModel> GetServices()
        {
            return new List<ServicesModel>()
            {
                new ServicesModel
                {
                    Name = "Free Checkup",
                    Icon = "/images/services/service_1.png",
                    Image = "/images/services/checkup.jpg",
                    Description = "Justo et est et voluptua dolor rebum exerci eum in magna facilisi clita kasd zzril sanctus diam diam est dolor consequat nonummy ea at ut liber magna clita voluptua sea exerci ipsum kasd tempor dolore zzril duo no dolores consetetur"
                },
                new ServicesModel
                {
                    Name = "Laboratory",
                    Icon = "/images/services/service_2.png",
                    Image = "/images/services/laboratory.jpg",
                    Description = "Justo et est et voluptua dolor rebum exerci eum in magna facilisi clita kasd zzril sanctus diam diam est dolor consequat nonummy ea at ut liber magna clita voluptua sea exerci ipsum kasd tempor dolore zzril duo no dolores consetetur"
                },
                new ServicesModel
                {
                    Name = "Ambulance",
                    Icon = "/images/services/service_3.png",
                    Image = "/images/services/ambulance.jpg",
                    Description = "Justo et est et voluptua dolor rebum exerci eum in magna facilisi clita kasd zzril sanctus diam diam est dolor consequat nonummy ea at ut liber magna clita voluptua sea exerci ipsum kasd tempor dolore zzril duo no dolores consetetur"

                },
                new ServicesModel
                {
                    Name = "Dental Care",
                    Icon = "/images/services/service_4.png",
                    Image = "/images/services/dental.jpg",
                    Description = "Justo et est et voluptua dolor rebum exerci eum in magna facilisi clita kasd zzril sanctus diam diam est dolor consequat nonummy ea at ut liber magna clita voluptua sea exerci ipsum kasd tempor dolore zzril duo no dolores consetetur"
                },
                new ServicesModel
                {
                    Name = "Emergency",
                    Icon = "/images/services/service_5.png",
                    Image = "/images/services/emergency.jpg",
                    Description = "Justo et est et voluptua dolor rebum exerci eum in magna facilisi clita kasd zzril sanctus diam diam est dolor consequat nonummy ea at ut liber magna clita voluptua sea exerci ipsum kasd tempor dolore zzril duo no dolores consetetur"
                },
                new ServicesModel
                {
                    Name = "Dental Care",
                    Icon = "/images/services/service_6.png",
                    Image = "/images/services/analysis.jpg",
                    Description = "Justo et est et voluptua dolor rebum exerci eum in magna facilisi clita kasd zzril sanctus diam diam est dolor consequat nonummy ea at ut liber magna clita voluptua sea exerci ipsum kasd tempor dolore zzril duo no dolores consetetur"
                }
            };
        }
    }
}
