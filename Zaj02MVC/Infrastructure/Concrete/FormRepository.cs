using System.Data.Entity;
using Zaj02MVC.Infrastructure.Interfaces;
using Zaj02MVC.Models;

namespace Zaj02MVC.Infrastructure.Concrete
{
    public class FormRepository:GenRepository<Formularz>,IFormRepository
    {
        public FormRepository(DbContext context)
            : base(context)
        {
            
        }
    }
}