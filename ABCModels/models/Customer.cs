using System.ComponentModel.DataAnnotations;

namespace ABCModels.models
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
