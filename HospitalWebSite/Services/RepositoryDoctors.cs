using HospitalWebSite.Models;

namespace HospitalWebSite.Services
{
    public class RepositoryDoctors
    {
        public List<SectionDoctorModel> GetDoctors()
        {
            return new List<SectionDoctorModel>
            {
                new SectionDoctorModel()
                {
                    Name= "Doctor 1",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor1.jpg",
                    Carrusel = "active"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 2",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor2.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 3",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor3.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 4",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor1.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 5",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor2.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 6",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor3.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 7",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor1.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 8",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor2.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 9",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor3.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 10",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor1.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 11",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor2.jpg"
                },
                new SectionDoctorModel()
                {
                    Name= "Doctor 12",
                    Title = "Lorem Ipsum",
                    ImageURL = "/images/doctors/doctor3.jpg"
                },
            };
        }
    }
}
