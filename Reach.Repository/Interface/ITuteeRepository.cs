using System;
using System.Collections.Generic;
using Reach.Entity;

namespace Reach.Repository
{
    public interface ITuteeRepository : IRepository<Tutee>
    {
        IEnumerable<Tutee> GetAllUndeletedTutees();
    }
}   
