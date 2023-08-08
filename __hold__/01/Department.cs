namespace DoctorOffice.Models;

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }

    public int SpecialtyId { get; set; }
    public Specialty Specialty { get; set; }

    public List<Location> Locations { get; set; }
}