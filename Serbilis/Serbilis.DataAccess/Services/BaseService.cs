using Serbilis.Core.Helpers;
using Serbilis.DataAccess.Interfaces;
using System.Collections.Generic;

namespace Serbilis.DataAccess.Services
{
    public class BaseService<TEntity> where TEntity : EntityBase
    {
        private readonly IGenericRepository<TEntity> _genericRepository;

        public BaseService(IGenericRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }


        public virtual TEntity GetbyId(int value)
        {
            return _genericRepository.GetById(value);
        }

        public virtual IEnumerable<TEntity> GetList()
        {
            return _genericRepository.Get();
        }

        public virtual void Create(TEntity entity)
        {
            _genericRepository.Insert(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _genericRepository.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _genericRepository.Delete(entity);
        }
    }
}
