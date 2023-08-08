using DoctorOffice.Models;

namespace DoctorOffice.Controllers;

public class PatientsController : Controller
{
    private readonly DoctorOfficeContext _db;

    public PatientsController(DoctorOfficeContext db)
    {
        _db = db;
    }

    /*
    public ActionResult Index()
    {}

    public ActionResult Create()
    {}

    [HttpPost]
    public ActionResult Create(Patient patient)
    {}

    public ActionResult Details(int id)
    {}

    public ActionResult AddDoctor(Patient patient, int doctorId)
    {}

    public ActionResult Edit(int id)
    {}

    [HttpPost]
    public ActionResult Edit(Patient patient)
    {}

    public ActionResult Delete(int id)
    {
        Patient patient = _db.Patients.FirstOrDefault(pat => pat.PatientId == id);
        _db.Patients.Remove(patient);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    */
}