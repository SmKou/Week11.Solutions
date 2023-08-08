using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Doctor
{
    public int DoctorId { get; set; }
    [Required(ErrorMessage = "Must include legal first name.")]
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    [Required(ErrorMessage = "Must include legal last name.")]
    public string LastName { get; set; }
    public string PreferredName { get; set; }
    [Required(ErrorMessage = "Must include legal birthdate.")]
    public DateTime BirthDate { get; set; }

    public bool IsOnResidence { get; set; }
    public bool IsOnInternship { get; set; }
    public bool IsResearchFellow { get; set; }
    public bool IsFullTime { get; set; }
    public bool IsClinicStaff { get; set; }
    public bool IsHeadStaff { get; set; }

    [Required(ErrorMessage = "Doctor must be registered with a provider.")]
    public int ProviderId { get; set; }
    public Provider Provider { get; set; }

    // office may be assigned later
    public int LocationId { get; set; }
    public Location Location { get; set; }

    public List<DoctorPatient> JoinPatients { get; }
    public List<DoctorSpecialty> JoinSpecialties { get; }

}