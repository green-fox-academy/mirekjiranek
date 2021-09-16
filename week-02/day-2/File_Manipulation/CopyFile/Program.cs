using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path_copy = @"Assets/copy.txt";
            string path_paste = @"Assets/paste.txt";

            Copy(path_copy, path_paste);
        }
        static void Copy(string Formerpath, string newpath)
        {
            try
            {
                string[] textOfFormerFile = File.ReadAllLines(Formerpath);
                for (int i = 0; i < textOfFormerFile.Length; i++)
                {
                    File.AppendAllText(newpath, textOfFormerFile[i] + "\n");
                }
                Console.WriteLine("Copy was succesfull");
            }
            catch (Exception)
            {
                Console.WriteLine("Copy wasn't succesfull");
            }
            //for (int i = 0; i < textOfFormerFile.Length; i++)
            //{
            //    File.WriteAllText(textOfFormerFile[i], textofNewFile[i]);
            //}


        }
    }
}
