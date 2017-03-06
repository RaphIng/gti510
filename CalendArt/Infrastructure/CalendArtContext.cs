using System.Data.Entity;
using CalendArt.Core.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace CalendArt.Infrastructure
{
    public class CalendArtContext : DbContext
    {
        public CalendArtContext()
            : base("name=CalendArtConnectionString")
        {
            Database.SetInitializer<CalendArtContext>(null); // database first
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Cours> Cours { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Tache> Taches { get; set; }
        public DbSet<Alert> Alert { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
