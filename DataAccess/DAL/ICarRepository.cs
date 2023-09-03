using Models.models;

namespace DataAccess.DAL
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int carId);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carId);
    }
}
