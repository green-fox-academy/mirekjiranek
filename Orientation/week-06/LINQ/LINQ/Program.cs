using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            Exercise3(n);
        }
        static public int[] Exercise1(int[] input)
        {
            //Write a LINQ Expression to get the even numbers from the following array:
            int[] output =  input.Where(input => input % 2 == 0).ToArray();
            return output;
        }
        static public double Exercise2(int[] input)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:
            var output = input.Where(input => input % 2 != 0).Average();
            return output;
        }
        static public List<int> Exercise3(int[] input)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            var output = input.Where(input => input > 0).Select(input => input * input).ToList();
            return output;

        }
    }
}
