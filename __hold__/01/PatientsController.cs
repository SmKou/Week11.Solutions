using DoctorOffice.Models;

namespace DoctorOffice.Controllers;

public class PatientsController : Controller
{
    private readonly DoctorOfficeContext _db;

    public PatientsController(DoctorOfficeContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        Patient[] patients = _db.Patients.ToArray();
        ViewBag.Patients = patients;
        return View();
    }
}