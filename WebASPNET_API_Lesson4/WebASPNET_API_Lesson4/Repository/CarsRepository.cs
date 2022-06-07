using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WebASPNET_API_Lesson4.Context;
using WebASPNET_API_Lesson4.Models;

namespace WebASPNET_API_Lesson4.Repository
{
    public class CarsRepository : ICarsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<CarsRepository> _logger;
        public CarsRepository(ApplicationDbContext context, IMapper mapper, ILogger<CarsRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        //private readonly List<Car> Cars = new();
        public IEnumerable<Car> GetAllCars()
        {
            _logger.LogInformation("Comand GET was send to get all cars");
            return _context.Cars;
        }
        public IEnumerable<Car> GetCarsByColor(string color)
        {
            _logger.LogInformation($"Comand GET was send to get all cars where ?color={color}");
            var filteredCarsByColor = _context.Cars.Where(x => x.Color == color);
            return filteredCarsByColor;
        }
        public IEnumerable<Car> AddNewCar(CarDto car)
        {
            try
            {
                _logger.LogInformation($"saving car to database {car}");
                var carToDb = _mapper.MapCarDtoToCar(car);
                _logger.LogInformation($"Mapper map CarDto to car Result\n{car}");
                _context.Cars.Add(carToDb);
                _context.SaveChanges();
                return _context.Cars;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return _context.Cars;
            }
        }
        public IEnumerable<Car> UpdateCar(CarDto car, Guid id)
        {

            try
            {
                _logger.LogInformation($"Updating car Id = {id}, with new values {car}");
                var carToUpdate = _context.Cars.Single(x => x.Id == id);
                carToUpdate.Type = car.Type;
                carToUpdate.Color = car.Color;
                carToUpdate.Speed = car.Speed;
                _context.SaveChanges();
                return _context.Cars;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return _context.Cars;
            }
        }
        public IEnumerable<Car> DeleteCar(Guid id)
        {
            try
            {
                _logger.LogInformation($"Deleting car with Id = {id}");
                var carToDelate = _context.Cars.Single(x => x.Id == id);
                _context.Cars.Remove(carToDelate);
                _context.SaveChanges();
                return _context.Cars;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return _context.Cars;
            }

        }
    }
}
