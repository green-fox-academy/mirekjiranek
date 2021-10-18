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
            int[] m = { 3, 9, 2, 8, 6, 5 };
            int[] p = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Exercise6("abcdeefg");
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
        static public List<int> Exercise4(int[] input)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            var output = input.Select(i => i * i).Where(i => i > 20).ToList();
            return output;
        }
        static public void Exercise5(int[] input)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            var grouped = input.GroupBy(g => g);
            var dict = grouped.ToDictionary(i => i.Key, i => i.Count());
            
        }
        static public void Exercise6(string input)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string.
            var grouped = input.ToCharArray().GroupBy(g => g);
            var dict = grouped.ToDictionary(d => d.Key, d => d.Count());
        }

    }
}
