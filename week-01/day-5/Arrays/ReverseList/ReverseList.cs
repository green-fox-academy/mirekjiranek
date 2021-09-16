using System;

namespace ReverseList
{
    class ReverseList
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements of `numbers`
            // - Print the elements of the reversed `numbers`
            int[] numbers = { 3, 4, 5, 6, 7 };
            for (int i = 0,swap; i < numbers.Length; i++)
            {
                if (i < (numbers.Length / 2))
                {
                    swap = numbers[i];
                    numbers[i] = numbers[numbers.Length - (1 + i)];
                    numbers[numbers.Length - (1 + i)] = swap;
                }
                Console.Write(numbers[i] + " ");

            }
        }
    }
}
