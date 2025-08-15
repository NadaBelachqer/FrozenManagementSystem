using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace FrozenInventorySystem.Controllers
{
    public class AccountController : Controller
    {
        private string connectionString = "Server=DESKTOP-9COPAU8;Database=FrozenInventoryDB;Integrated Security=True;";

        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string login, string motdepasse)
        {
            try
            {
                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(motdepasse))
                {
                    ViewBag.Error = "L'identifiant et le mot de passe sont requis";
                    return View();
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT MotDePasseHash, TypeCompte FROM Utilisateurs WHERE Login = @Login AND Actif = 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", login);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string motDePasseHash = reader["MotDePasseHash"].ToString();
                        string typeCompte = reader["TypeCompte"].ToString();

                        bool passwordVerified = false;

                        if (motDePasseHash == motdepasse)
                        {
                            passwordVerified = true;
                        }
                        else if (motDePasseHash.StartsWith("$2a$") &&
                                BCrypt.Net.BCrypt.Verify(motdepasse, motDePasseHash))
                        {
                            passwordVerified = true;
                        }
                        else if (VerifySHA256Password(motdepasse, motDePasseHash))
                        {
                            passwordVerified = true;
                        }

                        if (passwordVerified)
                        {
                            Session["UserLogin"] = login;
                            Session["UserType"] = typeCompte;
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }

                ViewBag.Error = "Identifiant ou mot de passe incorrect";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Une erreur s'est produite lors de la connexion";
                // Loguer l'exception (ex) dans un fichier log
                return View();
            }
        }

        private bool VerifySHA256Password(string password, string hashedPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash retourne un tableau de byte
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir le tableau de byte en string hexadécimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString().Equals(hashedPassword, StringComparison.OrdinalIgnoreCase);
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}