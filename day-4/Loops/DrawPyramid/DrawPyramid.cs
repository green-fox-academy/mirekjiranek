using System;

namespace DrawPyramid
{
    class DrawPyramid
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            Console.Write("Give me number of lines of pyramid: ");
            string numOfLines = Console.ReadLine();
            int numOfLinesInt = int.Parse(numOfLines);

            for (int i = 0; i != numOfLinesInt; i++)
            {
                for (int u = numOfLinesInt -1; u >= 0; u--)
                {
                    Console.Write(" ");
                    for (int q = 1; q <= i; q = q + 2)
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
