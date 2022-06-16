using Lab05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab05.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubik
        DBContext dbContext = new DBContext();
        public ActionResult Index()
        {
            ViewBag.TitlePageName = "Rubik view page";
            List<Rubik> listRubik = (from r in dbContext.Rubik select r).ToList();
            return View(listRubik);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null) return HttpNotFound();
            Rubik rubik = (from r in dbContext.Rubik select r).SingleOrDefault(s => s.id == id);
            if (rubik == null) return HttpNotFound();
            return View(rubik);
        }
    }
}