using System;

namespace AnimalsAndLegs
{
    class AnimalsAndLegs
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.Write("Give me the number of chick: ");
            string chickens = Console.ReadLine();
            int chickensInt = int.Parse(chickens) * 2;
            Console.Write("Give me the number of pigs: ");
            string pigs = Console.ReadLine();
            int pigsInt = int.Parse(pigs) * 4;
            int numOfLegs = chickensInt + pigsInt;
            Console.WriteLine($"All animals have {numOfLegs} legs in total.");

        }
    }
}
