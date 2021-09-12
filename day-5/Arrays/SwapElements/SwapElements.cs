using System;

namespace SwapElements
{
    class SwapElements
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`
            string[] orders = {"first", "second", "third","fourth","fifth" };
            string swap = orders[0];
            orders[0] = orders[orders.Length-1];
            orders[orders.Length-1] = swap;
            for (int i = 0; i < orders.Length; i++)
            {
                Console.WriteLine(orders[i]);
            }
        }
    }
}
