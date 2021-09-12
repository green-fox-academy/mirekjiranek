using System;

namespace PrintBigger
{
    class PrintBigger
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.Write("Write first number: ");
            string num1 = Console.ReadLine();
            int num1Int = int.Parse(num1);

            Console.Write("Write second number: ");
            string num2 = Console.ReadLine();
            int num2Int = int.Parse(num2);

            if (num1Int > num2Int)
            {
                Console.WriteLine($"First number({num1Int}) is bigger");
            }
            else if (num1Int == num2Int)
            {
                Console.WriteLine($"Both numbers({num1Int}) are equal.");
            }
            else
            {
                Console.WriteLine($"Second number({num2Int}) is bigger");
            }

        }
    }
}
