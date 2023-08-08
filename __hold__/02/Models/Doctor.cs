using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Doctor
{
    public int DoctorId { get; set; }
    [Required(ErrorMessage = "Doctor requires a name to be identified by.")]
    public string DoctorName { get; set; }
    public bool IsFullTime { get; set; }
    public bool IsHeadStaff { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }

    public List<DoctorSpecialty> DoctorSpecialties { get; set; }
    public List<DoctorPatient> DoctorPatients { get; set; }
}