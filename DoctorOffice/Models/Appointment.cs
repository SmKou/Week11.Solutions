namespace DoctorOffice.Models;

public class Appointment
{
    public int AppointmentId { get; set; }
    public int DoctorPatientId { get; set; }
    public DateTime AppointmentTime { get; set; }
    public int Location { get; set; }
    public string Note { get; set; }
}