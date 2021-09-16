using System;

namespace DrawTriangle
{
    class DrawTraingle
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.Write("Give me number of lines of triangle: ");
            string numOfLines = Console.ReadLine();
            int numOfLinesInt = int.Parse(numOfLines);

            for (int i = 0; i != numOfLinesInt; i++)
            {
                for (int u = 0; u <= i; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
