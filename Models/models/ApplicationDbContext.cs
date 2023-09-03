using Microsoft.EntityFrameworkCore;

namespace Models.models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=ABC_New; Integrated Security=true; TrustServerCertificate=true");
            }
        }
        public  DbSet<Car> Cars { get; set; }
        public  DbSet<Booking> Bookings { get; set; }
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<CarBooking> CarBookings { get; set; }

    }
}
