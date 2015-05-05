using System.Collections.Generic;

namespace Zaj02MVC.BLL.Interfaces
{

    public interface IEntityService<T> 
        where T : class
    {
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
