using System.Data.Entity;
using WQuasar.Models.Entities;

namespace WQuasar.Models.DbContexts
{
    class QuasarDbContext : DbContext
    {
        public QuasarDbContext()
            : base("QuasarConnection")
        { }

        public DbSet<Service> Services { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}