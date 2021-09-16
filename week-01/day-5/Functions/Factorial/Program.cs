using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `calculateFactorial()`
            //   that returns the factorial of its input
            Console.WriteLine(calculateFactorial(5));

            }
        static int calculateFactorial(int sizeOfFactorial)
        {
            int x = 1;
            Console.Write($"Factorial({sizeOfFactorial}) = ");
            for (int i = 1; i <= sizeOfFactorial ; i++)
            {
                x = x * i;
                if (i < sizeOfFactorial)
                {
                    Console.Write($"{i} * ");
                }
                else
                {
                    Console.Write($"{i} = ");
                }
            }
            return x;
        }
        }
    }
