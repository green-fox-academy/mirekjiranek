using System;

namespace FindPartOfAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and an array of integers as parameters
            //  It returns the indices of the integers of the array which contain the given number
            //  or returns an empty array (if the number is not part of any of the integers in the array)

            //  Example:
            //Console.WriteLine(FindMatchingIndexes(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //Console.WriteLine(FindMatchingIndexes(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'
            FindMatchingIndexes(2, new int[] { -251, 24, 1, 0, 85, 1958, -24, 152 });

            }
        static void FindMatchingIndexes(int selectedNum, int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                int  findAnumber = array[i];
                while (findAnumber >= 1)
                {
                    if (findAnumber % 10 == selectedNum)
                    {
                        findAnumber /= 10;
                        Console.Write($"{i}, ");
                    }
                    else
                    {
                        findAnumber /= 10;
                    }
                }
            }
            Console.Write("]");
        }
    }
    }
