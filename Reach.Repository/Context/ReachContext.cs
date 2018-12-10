using System;
using Microsoft.EntityFrameworkCore;
using Reach.Entity;
using MySql.Data;
using MySql;
namespace Reach.Repository
{
    public class ReachContext : DbContext
    {
        //public string connectionString = "server=127.0.0.1;uid=root;pwd=admin@2018;database=ReachTest";
     
        public ReachContext(DbContextOptions<ReachContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  No Implemention by REACH
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TuteeData.Seed(modelBuilder);
            MasterData.Seed(modelBuilder);
        }

        public DbSet<Tutee> Tutees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
      
    }
}
