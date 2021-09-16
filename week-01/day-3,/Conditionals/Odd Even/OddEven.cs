using System;

namespace Odd_Even
{
    class OddEven
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // then prints "Odd" if the number is odd, or "Even" if it is even.
            Console.Write("Write a number: ");
            string input = Console.ReadLine();
            int IntNumber = int.Parse(input);
            if (IntNumber % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
