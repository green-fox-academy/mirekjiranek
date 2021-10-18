using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //int[] m = { 3, 9, 2, 8, 6, 5 };
            //int[] p = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //Console.WriteLine(Exercise9(new char[] { 'a', 'h', 'o', 'j' }));

            //EXERCISE 10---------------------------------------------------------------------
            //Fox fox1 = new Fox("fox1", "green", "pallida");
            //Fox fox2 = new Fox("fox2", "gold", "pallida");
            //Fox fox3 = new Fox("fox3", "green", "dfgdfg");
            //Fox fox4 = new Fox("fox4", "green", "pallida");
            //Fox fox5 = new Fox("fox5", "blue", "fox1_color");
            //Fox fox6 = new Fox("fox6", "white", "fox1_color");
            //List<Fox> Foxes = new List<Fox>();
            //Foxes.Add(fox1);
            //Foxes.Add(fox2);
            //Foxes.Add(fox3);
            //Foxes.Add(fox4);
            //Foxes.Add(fox5);
            //Foxes.Add(fox6);
            //var clr = Foxes.Where(f => f.Color == "green").ToList();
            //var clr_type = Foxes.Where(f => f.Color == "green" && f.Type == "pallida").ToList();
            //----------------------------------------------------------------------------------
            string filepath = @"C:\Users\Miroslav\cmder\greenfox\mirekjiranek\Orientation\week-06\LINQ\LINQ\TextFile1.txt";
            string[] filecontent = File.ReadAllText(filepath).Split(" ");
            var grouped = filecontent.GroupBy(g => g);
            var dict = grouped.ToDictionary(d => d.Key, d => d.Count());
            var sorted = dict.OrderByDescending(s => s.Value).Take(100).ToList();

            foreach (KeyValuePair<string,int> kvp in sorted)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
        static public int[] Exercise1(int[] input)
        {
            //Write a LINQ Expression to get the even numbers from the following array:
            int[] output = input.Where(input => input % 2 == 0).ToArray();
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
        static public void Exercise7(string[] input)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            input.Where(o => o.StartsWith('A') && o.EndsWith('I')).ToList().ForEach(x => Console.WriteLine(x));         
        }
        static public void Exercise8(string input)
        {
            //Write a LINQ Expression to find the uppercase characters in a string.
            var substr = input.Where(x => char.IsUpper(x));
            foreach (var x in substr)
            {
                Console.WriteLine(x);
            }
        }
        static public string Exercise9(char[] input)
        {
            //Write a LINQ Expression to convert a char array to a string.
            var conv = string.Join("", input.Select(i => i)).ToString();
            return conv;
        }

    }
}
