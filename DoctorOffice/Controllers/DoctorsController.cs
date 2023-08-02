using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoctorOffice.Models;

public class DoctorsController : Controller
{
    private readonly DoctorOfficeContext _db;

    public DoctorsController(DoctorOfficeContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        Doctor[] doctors = _db.Doctors.ToArray();
        ViewBag.Doctors = doctors;
        return View();
    }
}