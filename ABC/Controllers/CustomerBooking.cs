using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.models;
using DataProvider.DataProvider;

namespace ABC.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CustomerBooking : ControllerBase
    {
        private readonly IDataProvider _dataProvider;

        public CustomerBooking(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        //to save the customer details from the Angular Html Form
        [HttpPost]
        public IActionResult AddCustomer([FromBody] DTO.CustomerBookingDTO customer)
        {
            Customer customerInfo = new Customer();
            customerInfo.CustomerName = customer.CustomerName;
            customerInfo.DrivingLicenseNum = customer.DrivingLicenseNum;
            customerInfo.Nationality = customer.Nationality;

            Booking bookingInfo = new Booking();
            bookingInfo.AdvancedPayment = customer.AdvancedPayment;
            bookingInfo.TransactionDate = customer.TransactionDate;

            try
            {
                _dataProvider.customerRepository.AddCustomer(customerInfo);
                var Addedcustomer = _dataProvider.customerRepository.GetCustomer(customer.CustomerName);
                bookingInfo.CustomerId = Addedcustomer.CustomerId;
                _dataProvider.bookingRepository.AddBooking(bookingInfo);
                return Ok(new
                {
                    bookingId = bookingInfo.BookingId,
                    TransactionDate = bookingInfo.TransactionDate.ToString()
                });
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while Adding customer");
            }
        }

    }
}
