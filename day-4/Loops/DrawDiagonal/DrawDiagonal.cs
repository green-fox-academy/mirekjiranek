using System;

namespace DrawDiagonal
{
    class DrawDiagonal
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.Write("Input a number: ");
            string userInput = Console.ReadLine();
            int lines = int.Parse(userInput);
            int columns = lines;

            for (int i = 0; i <= lines; i++)
            {
                for (int j = lines; j >= 0; j--) 
                {
                    
                }
            }
        }
    }
}
