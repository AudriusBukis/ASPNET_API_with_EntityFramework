using WebASPNET_API_Lesson4.Models;

namespace WebASPNET_API_Lesson4.Repository
{
    public class Mapper : IMapper
    {
        public Car MapCarDtoToCar(CarDto carDto)
        {
            return new Car(carDto.Type, carDto.Color, carDto.Speed);
        }
    }
}
