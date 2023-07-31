using ToDoList.Models;

namespace ToDoList.Controllers;

public class HomeController : Controller
{
    private readonly ToDoListContext _db;

    public HomeController(ToDoListContext db)
    {
        _db = db;
    }
    
    public ActionResult Index()
    {
        Category[] categories = _db.Categories.ToArray();
        Item[] items = _db.Items.ToArray();
        Dictionary<string, object[]> model = new Dictionary<string, object[]>();
        model.Add("categories", categories);
        model.Add("items", items);
        return View(model);
    }

    /*
        List<Category> categories = _db.Categories.ToList();
        List<Item> items = _db.Items.ToList();
        ViewBag.categories = categories;
        ViewBag.items = items;
        return View();
    */
}
