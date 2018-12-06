using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Reach.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext Context {get;set;}

        public IEnumerable<TEntity> GetAll(){
            return Context.Set<TEntity>();
        }

        public TEntity GetById(object id){
            return Context.Set<TEntity>().Find(id);
        }

        public void add(TEntity entity){
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void addRange(IEnumerable<TEntity> entities){
            Context.Set<TEntity>().AddRange(entities);
            Context.SaveChanges();
        }

        public void Remove(TEntity entity){
            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities){
            Context.Set<TEntity>().RemoveRange(entities);
            Context.SaveChanges();
        }
    }
}
