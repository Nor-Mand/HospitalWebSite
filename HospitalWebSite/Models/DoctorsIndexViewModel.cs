namespace HospitalWebSite.Models
{
    public class DoctorsIndexViewModel
    {
        public IEnumerable<SectionDoctorModel> Doctors { get; set; }
        public IEnumerable<SectionTitleModel> Titles { get; set; }

    }
}
