using Models.models;

namespace DataAccess.DAL
{
    public class CarBookingRepository : ICarBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public CarBookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCarBooking(CarBooking carBooking)
        {
            _context.CarBookings.Add(carBooking);
            _context.SaveChanges();
        }
    }
}
