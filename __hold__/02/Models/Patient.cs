using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Patient
{
    public int PatientId { get; set; }
    [Required(ErrorMessage = "Patient requires a name to be identified by.")]
    public string PatientName { get; set; }
    public bool IsInPatient { get; set; }
    public bool IsLongTermCare { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }
}