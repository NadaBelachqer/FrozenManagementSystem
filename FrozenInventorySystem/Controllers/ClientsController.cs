using System.Web.Mvc;

namespace FrozenInventorySystem.Controllers
{
    public class ClientsController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Title = "Gestion des Clients";
            return View();
        }
    }
}