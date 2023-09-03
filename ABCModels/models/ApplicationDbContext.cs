using Microsoft.EntityFrameworkCore;

namespace ABCModels.models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public  DbSet<Car> Cars { get; set; }
        public  DbSet<Booking> Bookings { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<CarBooking> CarBookings { get; set; }

    }
}
