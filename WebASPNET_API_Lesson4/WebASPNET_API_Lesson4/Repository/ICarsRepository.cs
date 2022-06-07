using System;
using System.Collections.Generic;
using WebASPNET_API_Lesson4.Models;

namespace WebASPNET_API_Lesson4.Repository
{
    public interface ICarsRepository
    {
        public IEnumerable<Car> GetAllCars();
        public IEnumerable<Car> GetCarsByColor(string color);
        public IEnumerable<Car> AddNewCar(CarDto car);
        public IEnumerable<Car> UpdateCar(CarDto car, Guid id);
        public IEnumerable<Car> DeleteCar(Guid id);
    }
}
