using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non - negative integer n, return the sum of its digits recursively(without loops).
            do
            {
                Console.Write("\nGive me n to sum the digits: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write(Sum(n));
            } while (true);

        }
        static int Sum(int n)
        {
            if (n < 10)
            {
                Console.Write($"{n%10} = ");
                return n % 10;
            }
            else
            {
                Console.Write(n%10 + " + ");
                return (n % 10) + Sum(n / 10);
            }
        }
    }
}
