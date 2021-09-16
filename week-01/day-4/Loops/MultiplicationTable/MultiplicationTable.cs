using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150
            Console.Write("Give me a number to multiply: ");
            string num = Console.ReadLine();
            int numInt = int.Parse(num);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * numInt);
            }
        }
    }
}
