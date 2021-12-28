using ApexRestuarant.Repository.Domain;
using ApexRestuarant.Repository.RCustomer;

namespace ApexRestaurant.Services.SCustomer
{
    public class CustomerService : GenericService<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository) :
        base(customerRepository)
        {

        }
    }
}