using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using unLost.Web.Models;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace unLost.Web.Controllers
{
    public class PupilController : Controller
    {
        [FromServices]
        public ApplicationDbContext db { get; set; }

        // GET: /<controller>/
        public IActionResult Edit(int? id)
        {
            Models.Pupil pupil;
            if (id == null)
            {
                pupil = null;
            }
            else
            {
                pupil = db.Pupils.Where(p => p.PupilId == id).First();
            }
            return View(pupil);
        }

        public IActionResult List()
        {
            return View(db.Pupils);
        }

        [HttpPost]
        public IActionResult Update(Forms.PupilEditFormPostback model)
        {
            var pupils = db.Pupils;
            Pupil pupil;
            if (model.Id == 0)
            {
                // new Item
                pupil = new Pupil();
                pupil.CandNo = model.Candno;
                pupil.Forename = model.Forename;
                pupil.Surname = model.Surname;
                pupil.Email = model.Email;
                pupil.TutorGpId = model.TutorGpId;
                pupils.Add(pupil);
            }
            else
            {
                // update existing item
                pupil = pupils.Where(p => p.PupilId == model.Id).First();
                pupil.CandNo = model.Candno;
                pupil.Forename = model.Forename;
                pupil.Surname = model.Surname;
                pupil.Email = model.Email;
                pupil.TutorGpId = model.TutorGpId;
            }
            db.SaveChanges();
            return Json(new UpdateResponse(true, "Changes saved", pupil.PupilId));
        }

        public IActionResult Items(int id)
        {
            var pupil = db.Pupils.Where(p => p.PupilId == id).First();
            return View(pupil);
        }

        public string ListJson()
        {
            var pupils = db.Pupils;
            return JsonConvert.SerializeObject(pupils, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }
    }
}
