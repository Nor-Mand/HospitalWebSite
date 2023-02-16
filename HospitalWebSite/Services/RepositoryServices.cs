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
                    Icon = "/images/services/service_1.png"
                },
                new ServicesModel
                {
                    Name = "Laboratory",
                    Icon = "/images/services/service_2.png"
                },
                new ServicesModel
                {
                    Name = "Ambulance",
                    Icon = "/images/services/service_3.png"
                },
                new ServicesModel
                {
                    Name = "Dental Care",
                    Icon = "/images/services/service_4.png"
                }
            };
        }
    }
}
