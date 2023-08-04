using Microsoft.AspNetCore.Mvc.Rendering;
using DoctorOffice.Models;

namespace DoctorOffice.Controllers;

public class SpecialtiesController : Controller
{
    private readonly DoctorOfficeContext _db;

    public SpecialtiesController(DoctorOfficeContext db)
    {
        _db = db;
    }

    public ActionResult Create()
    {
        ViewBag.DepartmentId = new SelectList(_db.Departments, "DepartmentId", "Name");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Specialty specialty)
    {
        if (!ModelState.IsValid)
            return View(0);

        _db.Specialties.Add(specialty);
        _db.SaveChanges();
        return RedirectToAction("Index", "Departments");
    }

    /*
    public ActionResult Edit(int id)
    {}

    [HttpPost]
    public ActionResult Edit(Specialty specialty)
    {}

    public ActionResult Delete(int id)
    {
        Specialty specialty = _db.Specialties.FirstOrDefault(spec => spec.SpecialtyId == id);
        _db.Specialties.Remove(specialty);
        _db.SaveChanges();
        return RedirectToAction("Index", "Departments");
    }
    */
}