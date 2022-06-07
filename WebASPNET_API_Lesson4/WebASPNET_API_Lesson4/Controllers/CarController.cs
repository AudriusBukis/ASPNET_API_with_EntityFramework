using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebASPNET_API_Lesson4.Models;
using WebASPNET_API_Lesson4.Repository;

namespace WebASPNET_API_Lesson4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarsRepository _carsRepository;
        public CarController(ICarsRepository carRepository)
        {
            _carsRepository = carRepository;
        }

        [HttpGet("GetAllCars")]
        public IEnumerable<Car> GetAllCars()
        {
            return _carsRepository.GetAllCars();
        }
        [HttpGet("GetCarsByColor")]
        public IEnumerable<Car> GetCarsByColor([FromQuery] string color)
        {
            return _carsRepository.GetCarsByColor(color);
        }
        [HttpPost("AddNewCar")]
        public Car AddNewCar([FromBody] CarDto car)
        {
            return _carsRepository.AddNewCar(car);
        }
        [HttpPut("UpdateCar/{id}")]
        public Car UpdateCar([FromBody] CarDto car, Guid id)
        {
            return _carsRepository.UpdateCar(car, id);
        }
        [HttpDelete("DeleteCar/{id}")]
        public Car DeleteCar([FromRoute] Guid id)
        {
            return _carsRepository.DeleteCar(id);
        }
    }
}
