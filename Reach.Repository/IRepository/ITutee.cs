using System;
using System.Collections.Generic;
using Reach.Entity;

namespace Reach.Repository.IRepository
{
    public interface ITuteeRepository : IRepository<Tutee>
    {
        IEnumerable<Tutee> DoSomeOtherTask();
    }
}
