using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Projet.Models
{
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }

        public DbSet<Albums> Albums { get; set; }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Tracks> Tracks { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}