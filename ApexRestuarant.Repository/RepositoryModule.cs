using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestuarant.Repository.RCustomer;

namespace ApexRestuarant.Repository
{
    public static class RepositoryModule
    {
        public static void Register(IServiceCollection services, string connection, string migrationsAssembly)
        {
            services.AddDbContext<RestuarantContext>(options => options.UseSqlite(connection, builder => builder.MigrationsAssembly(migrationsAssembly)));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
        }
    }
}