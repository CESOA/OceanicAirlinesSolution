using System.Data.Entity;
using App.Models;

namespace App.App_Data.Database
{
    public class SolutionContext : DbContext
    {
        public SolutionContext() : base("MS_TableConnectionString")
        {

        }

        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}