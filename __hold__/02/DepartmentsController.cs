using DoctorOffice.Models;

namespace DoctorOffice.Controllers;

public class DepartmentsController : Controller
{
    private readonly DoctorOfficeContext _db;

    public DepartmentsController(DoctorOfficeContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("Departments", _db.Departments.ToList());
        model.Add("Locations", _db.Locations.ToList());
        model.Add("Specialties", _db.Specialties.ToList());
        return View(model);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        _db.Departments.Add(department);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Department department = _db.Departments
            .Include(dpt => dpt.Locations)
            .Include(dpt => dpt.Specialties)
            .FirstOrDefault(dpt => dpt.DepartmentId == id);
        DptLocSpec dls = new DptLocSpec();
        dls.Dpt = department;
        return View(dls);
    }

    public ActionResult AddLocation(DptLocSpec dls)
    {
        dls.Loc.DepartmentId = dls.Dpt.DepartmentId;
        _db.Locations.Add(dls.Loc);
        _db.SaveChanges();
        return RedirectToAction("Details", new { id = dls.Dpt.DepartmentId });
    }

    public ActionResult AddSpecialty(DptLocSpec dls)
    {
        dls.Spec.DepartmentId = dls.Dpt.DepartmentId;
        _db.Specialties.Add(dls.Spec);
        _db.SaveChanges();
        return RedirectToAction("Details", new { id = dls.Dpt.DepartmentId });
    }

    /*
    public ActionResult Edit(int id)
    {}

    [HttpPost]
    public ActionResult Edit(Department department)
    {}
    */

    public ActionResult Delete(int id)
    {
        if (id == 1)
            return RedirectToAction("Index");

        Department department = _db.Departments
            .FirstOrDefault(dpt => dpt.DepartmentId == id);

        List<Location> locations = _db.Locations
            .Where(loc => loc.DepartmentId == id)
            .ToList();
        foreach (Location loc in locations)
        {
            loc.DepartmentId = 1;
            _db.Locations.Update(loc);
        }
        List<Specialty> specialties = _db.Specialties
            .Where(spec => spec.DepartmentId == id)
            .ToList();
        foreach (Specialty spec in specialties)
        {
            spec.DepartmentId = 1;
            _db.Specialties.Update(spec);
        }

        _db.Departments.Remove(department);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}