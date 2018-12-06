using System;
using System.Collections.Generic;

namespace Reach.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(object id);

        void add(TEntity entity);

        void addRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
