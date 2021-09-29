using System;

namespace DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me number how big the square should be: ");
            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                if (i == 0 || i == numOfLines - 1)
                {
                    for (int j = 0; j < numOfLines; j++)
                    {
                        Console.Write("%");
                    }
                }
                else
                {
                    Console.Write("%");
                    for (int f = 0; f < numOfLines - 2; f++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                }
                Console.WriteLine();
            }

        }
    }
}
