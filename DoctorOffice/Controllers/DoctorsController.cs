using Microsoft.AspNetCore.Mvc.Rendering;
using DoctorOffice.Models;

namespace DoctorOffice.Controllers;

public class DoctorsController : Controller
{
    private readonly DoctorOfficeContext _db;

    public DoctorsController(DoctorOfficeContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        List<Doctor> model = _db.Doctors
            .Include(doctor => doctor.Location)
            .Include(doctor => doctor.DoctorSpecialties)
            .ThenInclude(join => join.Specialty)
            .Include(doctor => doctor.DoctorPatients)
            .ThenInclude(join => join.Patient)
            .ToList();
        return View(model);
    }

    public ActionResult Create()
    {
        ViewBag.LocationId = _db.Locations
            .Select(location => new SelectListItem { 
                Value = location.LocationId.ToString(),
                Text = location.Floor + "." + location.Room
            });
        return View();
    }

    [HttpPost]
    public ActionResult Create(Doctor doctor)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.LocationId = new SelectList(_db.Locations, "LocationId", "FloorRoom");
            return View();
        }

        _db.Doctors.Add(doctor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    /*
    public ActionResult Details(int id)
    {}

    public ActionResult AddPatient(Doctor doctor, int patientId)
    {}

    public ActionResult AddSpecialty(Doctor doctor, int specialtyId)
    {}

    public ActionResult Edit(int id)
    {}

    [HttpPost]
    public ActionResult Edit(Doctor doctor)
    {}

    public ActionResult Delete(int id)
    {
        Doctor doctor = _db.Doctors.FirstOrDefault(doc => doc.DoctorId == id);
        _db.Doctors.Remove(doctor);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    */
}