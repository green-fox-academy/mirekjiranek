﻿using System;

namespace Bmi
{
    class Bmi
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;
            double bmi = massInKg / Math.Pow(heightInM, 2);

            Console.WriteLine($"Body mass index is {bmi}");
        }
    }
}
