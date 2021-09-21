using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new();
            car1.GetCapacity();
            Station station = new();
            station.Refill(car1);
            car1.GetCapacity();
            
        }
    }
}
