using Models.models;

namespace DataAccess.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

   

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //To Add A new Customer to the DataBase
        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public Customer GetCustomer(string name)
        {
            var customer = _dbContext.Customers.FirstOrDefault(z => z.CustomerName == name);
            return customer;
        }

    }
}
