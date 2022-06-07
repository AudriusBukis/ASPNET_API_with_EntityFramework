using System;
using System.Collections.Generic;
using WebASPNET_API_Lesson4.Models;

namespace WebASPNET_API_Lesson4.Repository
{
    public interface ICarsRepository
    {
        public IEnumerable<Car> GetAllCars();
        public IEnumerable<Car> GetCarsByColor(string color);
        public Car AddNewCar(CarDto car);
        public Car UpdateCar(CarDto car, Guid id);
        public Car DeleteCar(Guid id);
    }
}
