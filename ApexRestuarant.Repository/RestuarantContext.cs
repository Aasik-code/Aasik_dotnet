using Microsoft.EntityFrameworkCore;
using ApexRestuarant.Repository.Domain;

namespace ApexRestuarant.Repository
{
    public class RestuarantContext : DbContext
    {

        public RestuarantContext(DbContextOptions<RestuarantContext> options) :
        base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}