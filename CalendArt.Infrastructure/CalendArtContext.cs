using System.Data.Entity;
using CalendArt.Core.Domain;

namespace CalendArt.Infrastructure
{
    public class CalendArtContext : DbContext
    {
        public CalendArtContext()
            : base("name=CalendArtContext")
        {

        }

        

        public DbSet<Cours> Cours { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Tache> Taches { get; set; }
    }
}
