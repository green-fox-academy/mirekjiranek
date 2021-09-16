using System;
using System.IO;

namespace Write_Multiple_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Assets/multiple.txt";
            Multiple(path, "mordor", 5);
        }
        static void Multiple(string path, string word, int number)
        {
            try
            {
                for (int i = 0; i < number; i++)
                {
                    File.AppendAllText(path, word + "\n");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Unable to write to file: {path}");
            }
        }
    }
}
