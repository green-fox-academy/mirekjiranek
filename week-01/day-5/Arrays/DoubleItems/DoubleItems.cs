using System;

namespace DoubleItems
{
    class DoubleItems
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            int[] numbers = { 3, 4, 5, 6, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]*2);
            }
        }
    }
}
