using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Events.Dal.Model;

namespace Events.Dal.Repository
{
    public class RepositoryBase<T>:IRepository<T>,IDisposable where T:class
    {
        private EventsDataContext _context;
        private DbSet<T> _dbSet;
        private bool _disposed = false;

        public RepositoryBase()
        {
            _context = new EventsDataContext();
            _dbSet = _context.Set<T>();
        }
        public void Add(T entry)
        {
            _dbSet.Add(entry);
        }

        public void AddRange(IEnumerable<T> entries)
        {
            _context.Configuration.AutoDetectChangesEnabled = false;
            foreach (var entry in entries)
            {
                Add(entry);
            }
            _context.Configuration.AutoDetectChangesEnabled = true;
        }

        public void Update(T entry)
        {
            _context.Entry(entry).State = EntityState.Modified;
            //_dbSet.Attach(entry);
        }

        public void Delete(T entry)
        {
            _dbSet.Attach(entry);
            _dbSet.Remove(entry);
        }

        public void Delete(Expression<Func<T, bool>> query)
        {
            foreach (var item in _dbSet.Where(query))
            {
                Delete(item);
            }
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T Get(Expression<Func<T, bool>> single)
        {
            return _dbSet.SingleOrDefault(single);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if(_disposed)
                return;
            if(disposing)
                _context.Dispose();
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);        
        }
    }
}
