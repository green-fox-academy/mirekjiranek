using System;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies(1, 3, ..) have the
            //normal 2 ears.The even bunnies(2, 4, ..) we'll say have 3 ears, because they each have a raised foot.
            //Recursively return the number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

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
            else if (num_of_bunnies % 2 == 0)
            {
                return 3 + CountEars(num_of_bunnies - 1);
            }
            else
            {
                return 2 + CountEars(num_of_bunnies - 1);
            }
        }
    }
}
