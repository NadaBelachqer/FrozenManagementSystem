using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrozenInventorySystem.Controllers
{
    public class TestConnexionBD : Controller
    {
        // GET: TestConnexionBD
        public ActionResult TestConnexionBD()
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ColdStockConnection"].ConnectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT COUNT(*) FROM Utilisateurs", connection);
                    var count = (int)command.ExecuteScalar();
                    return Content($"Connexion réussie! Utilisateurs trouvés: {count}");
                }
            }
            catch (Exception ex)
            {
                return Content($"Échec de connexion: {ex.Message}");
            }
        }
    }
}