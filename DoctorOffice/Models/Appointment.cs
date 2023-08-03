namespace DoctorOffice.Models;

public class Appointment
{
    public int AppointmentId { get; set; }
    public string PatientComment { get; set; }
    public string AppointmentDate { get; set; }
    public string AppointmentTime { get; set; }

    public int LocationId { get; set; }
    public Location Location { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }
}