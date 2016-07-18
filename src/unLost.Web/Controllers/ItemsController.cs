using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Data.Entity;
using unLost.Web.Models;

namespace unLost.Web.Controllers
{
    public class ItemsController : Controller
    {
        [FromServices]
        public ApplicationDbContext db { get; set; }

        // GET: /<controller>/
        public IActionResult List(string id)
        {
            IQueryable<Models.Item> items;
            switch (id) {
                case "All":
                    items = db.Items;
                    break;
                case "Archive":
                    items = db.Items.Where(i => i.Collected != null);
                    break;
                default:
                    items = db.Items.Where(i => i.Collected == null);
                    break;
            }
            return View(new ViewModels.ListItemsModel(id, items));
        }

        public IActionResult Edit(int? id)
        {
            Models.Item item;
            if (id == null)
            {
                item = null;
            }
            else
            {
                item = db.Items.Where(i => i.ItemId == id).First();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Update(Models.Forms.ItemEditFormPostback model)
        {
            var items = db.Items;
            Item item;
            if (model.Id == 0)
            {
                // new Item
                item = new Models.Item();
                item.PupilId = model.Pupil;
                item.ItemCat = model.Cat;
                item.ItemSubcat = model.Subcat;
                item.ItemDesc = model.Desc;
                item.Added = DateTime.UtcNow;
                items.Add(item);
            } else
            {
                // update existing item
                item = items.Where(i => i.ItemId == model.Id).First();
                item.PupilId = model.Pupil;
                item.ItemCat = model.Cat;
                item.ItemSubcat = model.Subcat;
                item.ItemDesc = model.Desc;
            }
            db.SaveChanges();
            return Json(new UpdateResponse(true, "Changes saved", item.ItemId));
        }

        public IActionResult Archive(int id)
        {
            var item = db.Items.Where(i => i.ItemId == id).First();
            item.Collected = DateTime.UtcNow;
            db.SaveChanges();
            return View(item);
        }
    }

    public class UpdateResponse
    {
        public bool success { get; set; }
        public string status { get; set; }
        public DateTime timestamp { get; set; }
        public int itemId { get; set; }

        public UpdateResponse(bool success, string status, int itemId)
        {
            this.success = success;
            this.status = status;
            this.itemId = itemId;
            this.timestamp = DateTime.UtcNow;
        }
    }
}
