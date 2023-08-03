using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Specialty
{
    public int SpecialtyId { get; set; }
    [Required(ErrorMessage = "Requires a name to identify by.")]
    public string SpecialtyName { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public List<DoctorSpecialty> DoctorSpecialties { get; set; }
}