namespace WebASPNET_API_Lesson4.Models
{
    public class CarDto
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            return $"Type ={Type}, Color = {Color}, Max Speed = {Speed} km/h";
        }
    }
}
