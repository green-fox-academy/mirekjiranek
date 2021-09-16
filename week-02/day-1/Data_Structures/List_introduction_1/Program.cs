using System;
using System.Collections.Generic;

namespace List_introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine(names.Count);
            names.Add("William");
            Console.WriteLine(names.Count);
            names.Add("John");
            names.Add("Amanda");
            
            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i+1}. " + $"{names[i]}");
            }

            names.RemoveAt(1);
            names.Reverse();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            names.Clear();
            Console.WriteLine(names.Count);


        }
    }
}
