namespace DoctorOffice.Models;

public class Specialty
{
    public int SpecialtyId { get; set; }
    public string SpecialtyName { get; set; }

    public List<DoctorSpecialty> JoinDoctors { get; set; }
}