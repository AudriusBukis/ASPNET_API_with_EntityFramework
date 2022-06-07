using System;

namespace WebASPNET_API_Lesson4.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public Car(string type, string color, int speed)
        {
            Id = Guid.NewGuid();
            Type = type;
            Color = color;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"Id = {Id},Type ={Type}, Color = {Color}, Max Speed = {Speed} km/h";
        }
    }
}
