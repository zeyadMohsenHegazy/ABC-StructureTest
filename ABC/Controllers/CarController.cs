using DataAccess.DAL;
using DataProvider.DataProvider;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.models;

namespace ABC.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IDataProvider _dataAccess;
        public CarController(IDataProvider dataAccess)
        {
            _dataAccess = dataAccess;
        }

        #region Action to Get All Cars
        [Route("~/Car/GetAllCars")]
        [HttpGet]
        public IActionResult GetAllCars()
        {
            try
            {
                var cars = _dataAccess.carRepository.GetAllCars();
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while retrieving all cars.");
            }
        }
        #endregion
        [HttpGet("{carId}")]
        public IActionResult GetCarById(int carId)
        {
            try
            {
                var car = _dataAccess.carRepository.GetCarById(carId);
                if (car == null)
                {
                    return NotFound($"Car with Id {carId} not found.");
                }
                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while retrieving the car.");
            }
        }

        [HttpPost]
        [Route("~/Car/AddOneCar")]
        public IActionResult AddCar([FromBody] Car car)
        {
            try
            {
                _dataAccess.carRepository.AddCar(car);
                return Ok("New Car Added");
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while Adding new car.");
            }
        }


    }
}
