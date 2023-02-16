using HospitalWebSite.Services;

namespace HospitalWebSite.Models
{
    public class GlobalIndexViewModel
    {
        public IEnumerable<SectionDoctorModel> Doctors { get; set; }
        public IEnumerable<SectionTitleModel> Titles { get; set; }
        public IEnumerable<ServicesModel> TypeServices { get; set; }

    }
}
