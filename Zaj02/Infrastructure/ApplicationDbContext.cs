using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Zaj02.Infrastructure
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

    public class AppDbContextPlz : DbContext
    {
        public AppDbContextPlz() : base("DefaultConnectionPlz")
        {
           
        }

        public DbSet<FormularzPlz> FormularzPlzes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}