using System.Collections.Generic;
using System.Linq;
using Zaj04.Models;
using Zaj04.Models.EF;
using Zaj04.Repository.Interfaces;

namespace Zaj04.Repository.Concrete
{
    public class StaticConferenceRepository:IConferenceRepository
    {
        private static readonly List<Conference> ConferenceRegistrations;

        static StaticConferenceRepository()
        {
            ConferenceRegistrations = new List<Conference>();
        }
        public void Add(Conference formularz)
        {
            ConferenceRegistrations.Add(formularz);
        }

        public IQueryable<Conference> GetAll()
        {
            return ConferenceRegistrations.AsQueryable();
        }

        public Conference Get(int id)
        {
            return ConferenceRegistrations.First(x => x.Id == id);
        }
    }
}