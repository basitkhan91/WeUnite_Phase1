using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Reach.Repository
{
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext DBContext {get;set;}

        public Repository(ReachContext _context){
           DBContext = _context;
        }

        public IEnumerable<TEntity> GetAll(){
           return  DBContext.Set<TEntity>();
        }

        public TEntity GetById(object id){
            return DBContext.Set<TEntity>().Find(id);
        }

        public void add(TEntity entity){
            DBContext.Set<TEntity>().Add(entity);
            DBContext.SaveChanges();
        }

        public void addRange(IEnumerable<TEntity> entities){
            DBContext.Set<TEntity>().AddRange(entities);
            DBContext.SaveChanges();
        }

        public void Remove(TEntity entity){
            DBContext.Set<TEntity>().Remove(entity);
            DBContext.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities){
            DBContext.Set<TEntity>().RemoveRange(entities);
            DBContext.SaveChanges();
        }

        //public IEnumerable<TEntity> Find(Func<Expression> predicate)
        //{
        //    //DBContext.Set<TEntity>().in
        //    return null;
        //}
    }
}
