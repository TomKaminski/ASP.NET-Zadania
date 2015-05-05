using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zaj04.Models.EF;
using Zaj04.Repository.Interfaces;

namespace Zaj04.Repository.Concrete
{
    public class EfConferenceRepository:IConferenceRepository,IDisposable
    {
        private BazaDanychEntities _context;

        public EfConferenceRepository()
        {
            _context = new BazaDanychEntities();
        }

        public void Add(Conference formularz)
        {
            _context.Conferences.Add(formularz);
            _context.SaveChanges();
        }

        public IQueryable<Conference> GetAll()
        {
            return _context.Conferences.AsQueryable();
        }

        public Conference Get(int id)
        {
            return _context.Conferences.SingleOrDefault(x => x.Id == id);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}