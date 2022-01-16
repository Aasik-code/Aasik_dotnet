using ApexRestuarant.Repository.Domain;
using ApexRestuarant.Repository;
using ApexRestuarant.Repository.RCustomer;

namespace ApexRestuarant.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RestuarantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}