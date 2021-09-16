using System;

namespace MileToKmConverter
{
    class MileToKmConverter
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            Console.Write("Give me the distance in miles: ");
            string distanceMiles = Console.ReadLine();
            double distanceKm = double.Parse(distanceMiles) * 1.609344;
            Console.WriteLine($"The distance is {distanceKm}km.");
        }
    }
}
