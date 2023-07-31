using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoList.Models;

namespace ToDoList.Controllers;

public class TagsController : Controller
{
    private readonly ToDoListContext _db;

    public TagsController(ToDoListContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        return View(_db.Tags.ToList());
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Tag tag)
    {
        _db.Tags.Add(tag);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult AddItem(int id)
    {
        Tag tag = _db.Tags
            .FirstOrDefault(tags => tags.TagId == id);
        ViewBag.ItemId = new SelectList(_db.Items, "ItemId", "Description");
        return View(tag);
    }

    [HttpPost]
    public ActionResult AddItem(Tag tag, int itemId)
    {
        #nullable enable
        ItemTag? joinEntity = _db.ItemTags
            .FirstOrDefault(join => (
                join.ItemId == itemId
                && join.TagId == tag.TagId
            ));
        #nullable disable
        if (joinEntity == null && itemId != 0)
        {
            _db.ItemTags.Add(new ItemTag()
            {
                ItemId = itemId,
                TagId = tag.TagId
            });
            _db.SaveChanges();
        }
        return RedirectToAction("Details", new { id = tag.TagId });
    }

    public ActionResult Details(int id)
    {
        Tag tag = _db.Tags
            .Include(tag => tag.JoinEntities)
            .ThenInclude(join => join.Item)
            .FirstOrDefault(tag => tag.TagId == id);
        return View(tag);
    }

    public ActionResult Edit(int id)
    {
        Tag tag = _db.Tags
            .FirstOrDefault(tag => tag.TagId == id);
        return View(tag);
    }

    [HttpPost]
    public ActionResult Edit(Tag tag)
    {
        _db.Tags.Update(tag);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        Tag tag = _db.Tags
            .FirstOrDefault(tag => tag.TagId == id);
        return View(tag);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        Tag tag = _db.Tags
            .FirstOrDefault(tag => tag.TagId == id);
        _db.Tags.Remove(tag);
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