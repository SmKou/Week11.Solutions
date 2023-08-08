using System.ComponentModel.DataAnnotations;

namespace DoctorOffice.Models;

public class Appointment
{
    public int AppointmentId { get; set; }
    public DateTime AppointmentTime { get; set; }
    public string Comment { get; set; }
    public bool IsBillPaid { get; set; }
    public float BillRemainderDue { get; set; }

    [Required(ErrorMessage = "A doctor must be assigned to the appointment.")]
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    [Required(ErrorMessage = "A patient is required to set an appointment.")]
    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    // use patient's provider
    public int ProviderId { get; set; }
    public Provider Provider { get; set; }

    [Required(ErrorMessage = "A location must be specified for an appointment")]
    public int LocationId { get; set; }
    public Location Location { get; set; }
}