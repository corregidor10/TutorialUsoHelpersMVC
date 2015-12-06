using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoPlantillaRM.Models;

namespace DemoPlantillaRM.Controllers
{
    public class HomeController : Controller
    {
        JugadoresEntities db= new JugadoresEntities();
        // GET: Home
        public ActionResult Index()
        {
            
            return View(db.Plantilla);
        }

        public ActionResult Alta()
        {
            return View(new Plantilla());
        }

        [HttpPost]
        public ActionResult Alta(Plantilla model)
        {

            if (ModelState.IsValid)
            {
                db.Plantilla.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}