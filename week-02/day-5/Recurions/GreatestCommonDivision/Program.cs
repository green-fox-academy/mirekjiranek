using System;

namespace GreatestCommonDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the greatest common divisor of two numbers using recursion.
            do
            {
                Console.Write("First number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                int y = int.Parse(Console.ReadLine());
                int Remember_y = y;

                if (x < y)
                {
                    int swap = x;
                    x = y;
                    y = swap;
                }
                Console.WriteLine(GreatestCommon(x, y, Remember_y));

            } while (true);

        }
        static int GreatestCommon(int x, int y, int Remember_y)
        {

            if (x == y)
            {
                return x;
            }

            else if (x % y == 0 && Remember_y % y == 0)
            {
                return y;
            }
            else
            {
                return GreatestCommon(x, y - 1, Remember_y);
            }


        }
    }
}
