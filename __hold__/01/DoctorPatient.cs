namespace DoctorOffice.Models;

public class DoctorPatient
{
    public int DoctorPatientId { get; set; }
    public string Relation { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }
}