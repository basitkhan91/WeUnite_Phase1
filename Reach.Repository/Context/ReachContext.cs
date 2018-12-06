using System;
using Microsoft.EntityFrameworkCore;
using Reach.Entity;

namespace Reach.Repository
{
    public class ReachContext : DbContext
    {
        public ReachContext(){

        }

        DbSet<Tutee> Tutee { get; set; }
        DbSet<Tutee> Tuter { get; set; }

    }
}
