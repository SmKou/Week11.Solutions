namespace DoctorOffice.Models;

public class DoctorOfficeContext : DbContext
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Patient> Patients { get; set; }

    public DbSet<Provider> Providers { get; set; }
    public DbSet<ProviderAcct> ProviderAccounts { get; set; }
    public DbSet<ProviderAuth> ProviderAuths { get; set; }

    public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
    public DbSet<DoctorPatient> DoctorPatients { get; set; }

    public DoctorOfficeContext(DbContextOptions options) : base(options) {}
}