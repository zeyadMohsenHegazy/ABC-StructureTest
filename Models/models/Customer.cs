using System.ComponentModel.DataAnnotations;

namespace Models.models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string Nationality { get; set; }

        public string DrivingLicenseNum { get; set; }
    }
}
