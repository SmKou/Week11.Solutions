using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Department
{
    public int DepartmentId { get; set; }
    [Required(ErrorMessage = "Department requires a name to be identified by.")]
    public string DepartmentName { get; set; }

    public List<Location> Locations { get; set; }
    public List<Specialty> Specialties { get; set; }
}