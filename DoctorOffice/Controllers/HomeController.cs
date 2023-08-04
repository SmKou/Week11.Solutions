using DoctorOffice.Models;

namespace DoctorOffice.Controllers;

public class HomeController : Controller
{
    private readonly DoctorOfficeContext _db;

    public HomeController(DoctorOfficeContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        ViewBag.Appointments = _db.Appointments
            .Include(appointment => appointment.Doctor)
            .Include(appointment => appointment.Patient)
            .Include(appointment => appointment.Location)
            .ToList();
        ViewBag.Hours = _db.OfficeHours.ToList();
        return View();
    }
}