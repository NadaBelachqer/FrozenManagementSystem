// Services/AuthenticationService.cs
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using FrozenInventorySystem.Models;

namespace FrozenInventorySystem.Services
{
    public class AuthenticationService
    {
        private readonly string _connectionString;

        public AuthenticationService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Utilisateurs Authentifier(string login, string motDePasse)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ColdStockConnection"].ConnectionString))
            {
                connection.Open();

                // Requête adaptée à votre schéma de base de données
                var query = @"
            SELECT UtilisateurID, Nom, Login, MotDePasseHash, TypeCompte 
            FROM Utilisateurs 
            WHERE Login = @Login AND Actif = 1";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var motDePasseHashStocke = reader["MotDePasseHash"].ToString();
                            var motDePasseHashSaisi = HashMotDePasse(motDePasse);

                            // Comparaison des hashs (ou mot de passe en clair pour les tests)
                            if (motDePasseHashStocke == motDePasseHashSaisi ||
                                motDePasseHashStocke == motDePasse) // Pour tester avec les mots de passe en clair
                            {
                                return new Utilisateurs
                                {
                                    UtilisateurID = Convert.ToInt32(reader["UtilisateurID"]),
                                    Nom = reader["Nom"].ToString(),
                                    Login = reader["Login"].ToString(),
                                    TypeCompte = reader["TypeCompte"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }

        private string HashMotDePasse(string motDePasse)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));
                var builder = new StringBuilder();

                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}