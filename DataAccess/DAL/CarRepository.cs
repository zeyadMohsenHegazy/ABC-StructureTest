using Models.models;

namespace DataAccess.DAL
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CarRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _dbContext.Cars.ToList();
        }

        public Car GetCarById(int carId)
        {
            return _dbContext.Cars.FirstOrDefault(c => c.CarId == carId);
        }

        public void AddCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        public void UpdateCar(Car car)
        {
            _dbContext.Cars.Update(car);
            _dbContext.SaveChanges();
        }

        public void DeleteCar(int carId)
        {
            var car = _dbContext.Cars.FirstOrDefault(c => c.CarId == carId);
            if (car != null)
            {
                _dbContext.Cars.Remove(car);
                _dbContext.SaveChanges();
            }
        }

    }
}
