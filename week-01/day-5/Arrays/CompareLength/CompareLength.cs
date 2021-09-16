using System;

namespace CompareLength
{
    class CompareLength
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`
            // - Print "secondArrayOfNumbers is longer" if 
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`
            // - Otherwise print: "firstArrayOfNumbers is the longer one"
            int[] firstArrayofNubers = { 1, 2, 3 };
            int[] SecondArrayofNubers = { 4, 5 };

            if (firstArrayofNubers.Length < SecondArrayofNubers.Length)
            {
                Console.WriteLine("SecondArrayofNumbers is longer");
            }
            else
                Console.WriteLine("FrstArrayoNumbers is longer");
        }
    }
}
