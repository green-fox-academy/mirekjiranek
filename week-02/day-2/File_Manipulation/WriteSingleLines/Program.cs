using System;
using System.IO;


namespace WriteSingleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Assets/my-file.txt";
            string pathh = "jklasdfsdblkj";
            writeToFile(pathh, "Miroslav Jiránek");
        }
        static void writeToFile(string soubor ,string name)
        {
            try
            {
                File.WriteAllText(null, name);
            }
            catch(Exception)
            {
                Console.WriteLine($"Unable to write to file: {soubor}");
            }
        }
    }
}
