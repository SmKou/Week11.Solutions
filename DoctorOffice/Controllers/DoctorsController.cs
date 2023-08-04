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

    public ActionResult Details(int id)
    {
        Doctor doctor = _db.Doctors
            .Include(doc => doc.DoctorSpecialties)
            .ThenInclude(join => join.Specialty)
            .Include(doc => doc.DoctorPatients)
            .ThenInclude(join => join.Patient)
            .FirstOrDefault(doc => doc.DoctorId == id);
        return View(doctor);
    }

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

    public ActionResult DeletePatient(int id)
    {
        DoctorPatient doctorPatient = _db.DoctorPatients
            .FirstOrDefault(dp => dp.DoctorPatientId == id);
        int dId = doctorPatient.DoctorId;
        _db.DoctorPatients.Remove(doctorPatient);
        _db.SaveChanges();
        return RedirectToAction("Details", new { id = dId })
    }

    public ActionResult DeleteSpecialty(int id)
    {
        DoctorSpecialty doctorSpecialty = _db.DoctorSpecialties
            .FirstOrDefault(ds => ds.DoctorSpecialtyId == id);
        int dId = doctorSpecialty.DoctorId;
        _db.DoctorSpecialties.Remove(doctorSpecialty);
        _db.SaveChanges();
        return RedirectToAction("Details", new { id = dId });
    }
}