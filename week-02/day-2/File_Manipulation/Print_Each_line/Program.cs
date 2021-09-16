using System;
using System.IO;

namespace Print_Each_line
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Assets/new-file.txt";
            try
            {
                string[] text = File.ReadAllLines(path);
                Console.WriteLine(text);
            }
            catch
            {
                Console.WriteLine("Unable to read the file");
            }
        }
    }
}
