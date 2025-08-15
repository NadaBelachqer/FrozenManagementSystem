using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrozenInventorySystem.Controllers
{
    public class ChambresController : Controller
    {
        // GET: Chambres
        public ActionResult Index()
        {
            ViewBag.Title = "Gestion des Chambres";

            return View();
        }
    }
}