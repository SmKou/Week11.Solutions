namespace DoctorOffice.Models;

public class DoctorOfficeContext : DbContext
{
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }

    public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
    public DbSet<DoctorPatient> DoctorPatients { get; set; }

    public DoctorOfficeContext(DbContextOptions options) : base(options) {}
}