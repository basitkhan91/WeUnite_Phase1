using System;
using System.Collections.Generic;
using Reach.Entity;

namespace Reach.Repository
{
    internal class TuteeRepository : Repository<Tutee> , ITuteeRepository
    {
        public ReachContext ReachContext { 
            get { return DBContext as ReachContext; } 
        }

        public TuteeRepository(ReachContext _context)
            :base(_context){
          
        }

        public IEnumerable<Tutee> GetAllUndeletedTutees(){
            throw new Exception("No implementation done by Reach");
        }
    }
}
