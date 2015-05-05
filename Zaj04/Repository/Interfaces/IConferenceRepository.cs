using System.Linq;
using Zaj04.Models;
using Zaj04.Models.EF;

namespace Zaj04.Repository.Interfaces
{
    public interface IConferenceRepository
    {
        void Add(Conference formularz);
        IQueryable<Conference> GetAll();
        Conference Get(int id);
    }
}
