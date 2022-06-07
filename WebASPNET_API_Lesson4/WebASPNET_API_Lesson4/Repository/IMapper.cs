using WebASPNET_API_Lesson4.Models;

namespace WebASPNET_API_Lesson4.Repository
{
    public interface IMapper
    {
        public Car MapCarDtoToCar(CarDto carDto);
    }
}
