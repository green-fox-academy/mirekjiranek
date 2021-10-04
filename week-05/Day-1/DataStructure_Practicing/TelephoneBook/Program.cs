using System;
using System.Collections.Generic;

namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> TelBook = new Dictionary<string, string>
            {
                ["William A. Lathan"] = "405-709-1865",
                ["John K. Miller"] = "402-247-8568",
                ["Hortensia E. Foster"] = "606-481-6467",
                ["Amanda D. Newland"] = "319-243-5613",
                ["Brooke P. Askew"] = "307-687-2982"
            };
            
            Console.WriteLine(PrintNumber(TelBook, "John K. Miller"));
            Console.WriteLine(PrintNumber(TelBook, "William A.Lan"));

            Console.WriteLine(PrintName(TelBook, "307-687-2982"));
            Console.WriteLine(PrintName(TelBook, "402-24-8568"));

        }
        static  string PrintNumber(Dictionary<string, string> input,string key)
        {
            if(input.ContainsKey(key))
            {
                return input[key];
            }
            else
            {
                return "There is no phone number for this name";
            }
        }
        static  string PrintName(Dictionary<string, string> input, string value)
        {
            foreach (KeyValuePair<string,string> s in input)
            {
                if (s.Value == value)
                {
                    return s.Key;
                }
            }
            return "There is no name for this phone number";

        }
    }
}
