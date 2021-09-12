﻿using System;

namespace OneTwoALot
{
    class OneTwoALot
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot

            Console.Write("Write a number: ");
            string input = Console.ReadLine();
            int inputInt = int.Parse(input);
            if (inputInt == 0 || inputInt < 0)
            {
                Console.WriteLine("Not enough.");
            }
            else if (inputInt == 1)
            {
                Console.WriteLine("One");
            }
            else if (inputInt == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }
        }
    }
}
