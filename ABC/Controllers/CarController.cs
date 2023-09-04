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
        private readonly IDataProvider _dataProvider;
        public CarController(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }


        [Route("~/Car/GetAllCars")]
        //URL will be http://localhost:55990/Car/GetAllCars
        [HttpGet]
        public IActionResult GetAllCars()
        {
            try
            {
                var cars = _dataProvider.carRepository.GetAllCars();
                return Ok(cars);
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while retrieving all cars.");
            }
        }


        [HttpGet]
        [Route("~/Car/GetOnlyOneCar")]
        //URL will be http://localhost:55990/Car/GetOnlyOneCar?carId=1
        public IActionResult GetCarById(int carId)
        {
            try
            {
                var car = _dataProvider.carRepository.GetCarById(carId);
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
        //URL will be http://localhost:55990/Car/AddOneCar
        public IActionResult AddCar([FromBody] Car car)
        {
            try
            {
                _dataProvider.carRepository.AddCar(car);
                return Ok("New Car Added");
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while Adding new car.");
            }
        }


    }
}
