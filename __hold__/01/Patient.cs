using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Patient
{
    public int PatientId { get; set; }
    [Required(ErrorMessage = "Must include legal first name.")]
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    [Required(ErrorMessage = "Must include legal last name.")]
    public string LastName { get; set; }
    public string PreferredName { get; set; }
    [Required(ErrorMessage = "Must include legal birthdate.")]
    public DateTime Birthdate { get; set; }

    public bool IsInPatient { get; set; }
    public bool IsLongTermCare { get; set; }
    public bool IsPermanentSupport { get; set; }

    [Required(ErrorMessage = "Patient must be registered with a provider.")]
    public int ProviderId { get; set; }
    public Provider Provider { get; set; }

    // assign only if in-patient or long-term care
    public int LocationId { get; set; }
    public Location Location { get; set; }

    public List<DoctorPatient> JoinDoctors { get; }
}