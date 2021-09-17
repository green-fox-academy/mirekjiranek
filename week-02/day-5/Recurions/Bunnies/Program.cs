using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have a number of bunnies and each bunny has two big floppy ears. We want to
            //compute the total number of ears across all the bunnies recursively(without loops or multiplication).

            do
            {
                Console.Write("Number of bunnies: ");
                int num_of_bunnies = int.Parse(Console.ReadLine());
                Console.WriteLine(CountEars(num_of_bunnies));

            } while (true);
        }
        static int CountEars(int num_of_bunnies)
        {
            if (num_of_bunnies <= 0)
            {
                Console.WriteLine("No bunnies or, negative input");
                return -1;
            }
            else if (num_of_bunnies == 1)
            {
                return 2;
            }
            else
            {
                return 2 + CountEars(num_of_bunnies - 1);
            }
        }
    }
}
