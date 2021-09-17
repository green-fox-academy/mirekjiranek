using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string, compute recursively(no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.
            do
            {
                Console.Write("Write a sentence: ");
                string sentence = Console.ReadLine();
                char[] charArr = sentence.ToCharArray();
                Console.WriteLine(ChangeX(charArr));

            } while (true);

            static string ChangeX(char[] charArr)
            {
             
            }
        }
    }
}
