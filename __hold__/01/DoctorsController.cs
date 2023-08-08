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
        List<Doctor> model = _db.Doctors.ToList();
        return View(model);
    }

    public ActionResult Create()
    {
        ViewBag.ProviderId = new SelectList(_db.Providers, "ProviderId", "ProviderName");
        if (ViewBag.ProviderId == null)
            return RedirectToAction("Create", "Providers");

        VIewBag.LocationId = new SelectList(_db.Locations, "LocationId", "RoomNo");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Doctor doctor)
    {
        if (!ModelState.IsValid)
        {
            
        }
        _db.Doctors.Add(doctor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}