using DataAccess.DAL;
using Models.models;

namespace DataProvider.DataProvider
{
    public class DataAccessProvider : IDataProvider
    {
        private readonly ApplicationDbContext _context;

        public DataAccessProvider( ApplicationDbContext applicationDb)
        {
            _context = applicationDb;
            carRepository = new CarRepository(_context);
            customerRepository = new CustomerRepository(_context);
            carBookingRepository = new CarBookingRepository(_context);
            bookingRepository = new BookingRepository(_context);
        }

        public ICarRepository carRepository { get; private set; }

        public ICustomerRepository customerRepository { get; private set; }

        public ICarBookingRepository carBookingRepository { get; private set; }

        public IBookingRepository bookingRepository { get; private set; }
    }
}
