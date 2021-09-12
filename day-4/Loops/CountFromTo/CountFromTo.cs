using System;

namespace CountFromTo
{
    class CountFromTo
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.Write("Give me number 1: ");
            string num1 = Console.ReadLine();
            int num1Int = int.Parse(num1);

            Console.Write("Give me number 2: ");
            string num2 = Console.ReadLine();
            int num2Int = int.Parse(num2);

            if (num1Int > num2Int)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for ( ; num1Int != num2Int; num1Int++)
                {
                    Console.WriteLine(num1Int);
                }
            }


        }
    }
}
