using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Introduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> List_A = new List<string>() { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> List_B = new List<string>(List_A);
            Console.WriteLine(List_A.Contains("Durian"));
            List_B.Remove("Durian");
            List_A.Insert(4, "Kiwifruit");
            Console.WriteLine(List_A.Count == List_B.Count);
            Console.WriteLine($"Index of Avocado in List A  is: " + List_A.IndexOf("Avocado"));
            Console.WriteLine($"Index of Durian in List B is: " + List_B.IndexOf("Durian"));
            List_B.AddRange(new List<string>() {"Passion Fruit", "Pomelo"});
            Console.WriteLine(List_A[3]);

        }
    }
}
