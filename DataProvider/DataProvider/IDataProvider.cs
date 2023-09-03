using DataAccess.DAL;

namespace DataProvider.DataProvider
{
    public interface IDataProvider
    {
        ICarRepository carRepository { get; }
        ICustomerRepository customerRepository { get; }
        ICarBookingRepository carBookingRepository { get; }
        IBookingRepository bookingRepository { get; }
    }
}
