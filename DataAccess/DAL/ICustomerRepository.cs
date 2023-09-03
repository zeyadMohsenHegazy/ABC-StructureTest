using Models.models;

namespace DataAccess.DAL
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        public Customer GetCustomer(string name);
    }
}
