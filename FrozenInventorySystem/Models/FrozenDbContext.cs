using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FrozenInventorySystem.Models
{
    public class FrozenDbContext : DbContext
    {
        public FrozenDbContext() : base("FrozenInventoryDB") { } // Nom identique à web.config

        public DbSet<Utilisateur> Utilisateurs { get; set; }
    }

}