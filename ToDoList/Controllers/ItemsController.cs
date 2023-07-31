using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoList.Models;

namespace ToDoList.Controllers;

public class ItemsController : Controller
{
    private readonly ToDoListContext _db;

    public ItemsController(ToDoListContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        List<Item> model = _db.Items
            .Include(item => item.Category)
            .ToList();
        return View(model);
    }

    public ActionResult Create()
    {
        ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
        return View();
    }

    [HttpPost]
    public ActionResult Create(Item item)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
            return View(item);
        }
        else {
            _db.Items.Add(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

    public ActionResult AddTag(int id)
    {
        Item item = _db.Items
            .FirstOrDefault(item => item.ItemId == id);
        ViewBag.TagId = new SelectList(_db.Tags, "TagId", "Title");
        return View(item);
    }

    [HttpPost]
    public ActionResult AddTag(Item item, int tagId)
    {
        bool hasEntity = _db.ItemTags.Any(join =>
            join.TagId == tagId
            && join.ItemId == item.ItemId
        );

        if (!hasEntity && tagId != 0)
        {
            _db.ItemTags.Add(new ItemTag()
            {
                TagId = tagId,
                ItemId = item.ItemId
            });
            _db.SaveChanges();
        }
        return RedirectToAction("Details", new { id = item.ItemId });
    }

    public ActionResult Details(int id)
    {
        Item item = _db.Items
            .Include(item => item.Category)
            .Include(item => item.JoinEntities)
            .ThenInclude(join => join.Tag)
            .FirstOrDefault(item => item.ItemId == id);
        return View(item);
    }

    public ActionResult Edit(int id)
    {
        Item item = _db.Items
            .FirstOrDefault(item => item.ItemId == id);
        ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
        return View(item);
    }

    [HttpPost]
    public ActionResult Edit(Item item)
    {
        _db.Items.Update(item);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        Item item = _db.Items
            .FirstOrDefault(item => item.ItemId == id);
        return View(item);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        Item item = _db.Items
            .FirstOrDefault(item => item.ItemId == id);
        _db.Items.Remove(item);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
        ItemTag joinEntry = _db.ItemTags
            .FirstOrDefault(entry => entry.ItemTagId == joinId);
        _db.ItemTags.Remove(joinEntry);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}
