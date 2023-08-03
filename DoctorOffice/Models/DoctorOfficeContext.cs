namespace DoctorOffice.Models;

public class DoctorOfficeContext : DbContext
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<OfficeHour> OfficeHours { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Patient> Patients { get; set; }

    public DbSet<DoctorPatient> DoctorPatients { get; set; }
    public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }

    public DoctorOfficeContext(DbContextOptions options) : base(options) {}
}