using System;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function called `sum()` that returns the sum of numbers from zero to the given parameter
            Console.WriteLine(sum(5));
            }
        static int sum(int numOfParameters)
        {
            int x = 0;
            Console.Write("Sum = ");
            for (int i  = 0; i <= numOfParameters; i++)
            {
                x = x + i;
                if (i < numOfParameters)
                {
                    Console.Write($"{i} + ");
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
