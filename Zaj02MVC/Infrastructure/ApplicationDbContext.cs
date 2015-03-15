using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Zaj02MVC.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Formularz> Formularze { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}