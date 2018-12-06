using System;
using System.Collections.Generic;
using Reach.Entity;

namespace Reach.Repository.Repository
{
    public class TuteeRepository : Repository<Tutee> , IRepository<Tutee>
    {
        public IEnumerable<Tutee> DoSomeOtherTask(){
            throw new Exception("No implementation done by Reach");
        }
    }
}
