using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Zaj02MVC.Infrastructure.Interfaces
{
    public interface IGenRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetSingle(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
        
    }
}
