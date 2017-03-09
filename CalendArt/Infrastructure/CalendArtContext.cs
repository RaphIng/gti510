using System.Data.Entity;
using CalendArt.Core.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;

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

        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
