using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.models
{
    public class CarBooking
    {
        [Key]
        public int CarBookingId { get; set; }

        public int RentDuration { get; set; }

        [ForeignKey("car")]
        public int CarId { get; set; }
        public virtual Car car { get; set; }


        [ForeignKey("booking")]
        public int BookingId { get; set; }
        public virtual Booking booking { get; set; }
    }
}
