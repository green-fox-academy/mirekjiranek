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
                int n = 0;
                Console.WriteLine(ChangeX(charArr));

            } while (true);

            static char ChangeX(char[] charArr, int n)
            {
             if (n == 0)
                {
                    return charArr[n];
                } 
             else if (charArr[n] == 'x')
                {
                    return charArr[n] = 'y';
                }
             else
                {
                    return charArr[n] + ChangeX(char[] charArr , n + 1);

                }
            }
        }
    }
}
