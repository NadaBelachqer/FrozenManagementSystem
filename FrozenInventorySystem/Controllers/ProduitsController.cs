using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrozenInventorySystem.Controllers
{
    public class ProduitsController : Controller
    {
        // GET: Produits
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Stock()
        {
            return View();
        }
    }
}