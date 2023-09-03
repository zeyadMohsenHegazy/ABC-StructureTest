using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess.DAL;
using Models.models;
using DataProvider.DataProvider;

namespace ABC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmBookingController : ControllerBase
    {
        private readonly IDataProvider _dataProvider;
        public ConfirmBookingController(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        [HttpPost]
        public IActionResult ConfirmBooking(CarBooking carBooking)
        {
            _dataProvider.carBookingRepository.AddCarBooking(carBooking);
            return Ok();
        }
    }
}
