using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Zaj02MVC.Infrastructure.Interfaces;

namespace Zaj02MVC.Infrastructure.Concrete
{
    public abstract class GenRepository<T> : IGenRepository<T>
      where T : class
    {
        protected DbContext Entities;
        protected readonly IDbSet<T> Dbset;

        protected GenRepository(DbContext context)
        {
            Entities = context;
            Dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {

            return Dbset.AsEnumerable();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return Dbset.FirstOrDefault(predicate);
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {

           return Dbset.Where(predicate).AsEnumerable();
            
        }

        public virtual T Add(T entity)
        {
            return Dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return Dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Entities.SaveChanges();
        }
    }
}