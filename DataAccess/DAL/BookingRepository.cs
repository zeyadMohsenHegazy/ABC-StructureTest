using Models.models;

namespace DataAccess.DAL
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;


        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }
    }
}
