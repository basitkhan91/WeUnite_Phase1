using System;
namespace Reach.Repository
{
   public interface IUnitOfWork
        {
            IRepository<T> Repository<T>() where T : class;
            ITuteeRepository TuteeRepository { get; }
            int Complete();
        }
}
