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
            Database.SetInitializer<CalendArtContext>(null);
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Cours> Cours { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Tache> Taches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database does not pluralize table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
