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
        List<Appointment> model = _db.Appointments
            .Include(appointment => appointment.Doctor)
            .Include(appointment => appointment.Patient)
            .Include(appointment => appointment.Provider)
            .Include(appointment => appointment.Location)
            .ToList();
        return View(model);
    }
}