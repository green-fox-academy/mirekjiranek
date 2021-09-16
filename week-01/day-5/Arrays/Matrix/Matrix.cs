
using System;

namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array dynamically with the following content.
            //   Note that a two dimensional array is often called matrix if every
            //   internal array has the same length.
            //   Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            //   Its length should depend on a variable
            //  
            // - Print this two dimensional array to the output
            int[,] matrix2D = new int[6,6];
            

            for (int i = 0; matrix2D.GetLength(0) > i; i++)
            {
                for (int j = 0; matrix2D.GetLength(1) > j; j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix2D[i,j] = 1);
                    }
                     else
                    {
                        Console.Write(matrix2D[i, j]);

                    }
                }
                Console.WriteLine();
            } 
        }
    }
}
