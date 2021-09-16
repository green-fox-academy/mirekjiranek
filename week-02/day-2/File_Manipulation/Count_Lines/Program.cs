using System;
using System.IO;

namespace Count_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Miroslav/cmder/greenfox/mirekjiranek/week-02/day-2/File_Manipulation/Count_Lines/Assets/myFile.txt";
            File.WriteAllText(path,"uj\n mmi\n");
            Counter(path);
        }
        static int Counter(string filename)
        {
            int i;
            try
            {
                i = File.ReadAllLines(filename).Length;
                Console.Write($"Number of lines in file: {i}");
                
            }
            catch(Exception)
            {
                return 0;
            }
            return i;

        }
    }
}
