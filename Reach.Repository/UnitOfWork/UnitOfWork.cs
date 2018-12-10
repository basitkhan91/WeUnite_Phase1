using System;
using Reach.Entity;

namespace Reach.Repository
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private ReachContext Context { get; set; }

        public UnitOfWork(ReachContext _context)
        {
            Context = _context;
        }

        public int Complete(){
           return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public ITuteeRepository TuteeRepository { get { return (ITuteeRepository) new TuteeRepository(Context); } }

        public IRepository<T> Repository<T>() where T : class {
            return new Repository<T>(Context);
        }
   }

}
