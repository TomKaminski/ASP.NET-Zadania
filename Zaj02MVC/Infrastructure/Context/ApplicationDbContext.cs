using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Zaj02MVC.Models;

namespace Zaj02MVC.Infrastructure.Context
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