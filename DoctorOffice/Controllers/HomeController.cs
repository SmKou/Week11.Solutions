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
        
        return View();
    }
}