using Microsoft.AspNetCore.Mvc.Rendering;
using DoctorOffice.Models;

namespace DoctorOffice.Controllers;

public class LocationsController : Controller
{
    private readonly DoctorOfficeContext _db;

    public LocationsController(DoctorOfficeContext db)
    {
        _db = db;
    }

    public ActionResult Create()
    {
        ViewBag.DepartmentId = new SelectList(_db.Departments, "DepartmentId", "Name");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Location location)
    {
        if (!ModelState.IsValid)
            return View();

        location.FloorRoom = location.Floor + "." + location.Room;
        _db.Locations.Add(location);
        _db.SaveChanges();
        return RedirectToAction("Index", "Departments");
    }

    /*
    public ActionResult Edit(int id)
    {}

    public ActionResult Edit(Location location)
    {}

    public ActionResult Delete(int id)
    {
        Location location = _db.Locations.FirstOrDefault(loc => loc.LocationId == id);
        _db.Locations.Remove(location);
        _db.SaveChanges();
        return RedirectToAction("Index", "Departments");
    }
    */
}