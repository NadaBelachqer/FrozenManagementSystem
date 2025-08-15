using System.Web.Mvc;
using System.Web.Security;

namespace FrozenInventorySystem.Controllers
{
    [Authorize] // <-- Ajoutez cette ligne pour protéger tout le contrôleur
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}