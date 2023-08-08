namespace DoctorOffice.Models;

public class DoctorOfficeContext : DbContext
{
    
    public DoctorOfficeContext(DbContextOptions options) : base(options) {}
}