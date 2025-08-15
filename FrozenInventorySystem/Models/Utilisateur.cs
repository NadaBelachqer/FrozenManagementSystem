using System.ComponentModel.DataAnnotations;

namespace FrozenInventorySystem.Models
{
    public class Utilisateur
    {
        public int UtilisateurID { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string MotDePasseHash { get; set; }

        public string TypeCompte { get; set; }
        public bool Actif { get; set; }
    }
}
