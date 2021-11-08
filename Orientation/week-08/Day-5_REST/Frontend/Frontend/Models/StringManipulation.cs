using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class StringManipulation
    {
        public string text { get; set; }
        public bool isEvenNumberOfWords(string text)
        {
            int a = 0;
            int WordCounter = 1;
            while (a <= text.Length - 1)
            {
                if (text[a] == ' ' || text[a] == '\n' || text[a] == '\t')
                {
                    WordCounter++;
                }
                a++;
            }
            return WordCounter % 2 == 0;
        }
        public string Reverser(string text)
        {
            string[] textArray = text.ToLower().Split(' ');
            for (int i = 0; i < textArray.Length - 1; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    string[] subArr = new string[] { textArray[i], textArray[i + 1] };
                    Array.Reverse(subArr);
                    textArray[i] = subArr[0];
                    textArray[i + 1] = subArr[1];
                }
            }
            return String.Join(" ", textArray);
        }
    }
}
