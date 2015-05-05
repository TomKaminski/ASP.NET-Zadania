using System;
using System.Collections.Generic;
using Zaj02MVC.BLL.Interfaces;
using Zaj02MVC.Infrastructure.Interfaces;

namespace Zaj02MVC.BLL.Concrete
{
    public abstract class EntityService<T> : IEntityService<T> where T : class
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IGenRepository<T> _repository;

        protected EntityService(IUnitOfWork unitOfWork, IGenRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);
            _unitOfWork.Commit();
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Edit(entity);
            _unitOfWork.Commit();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}