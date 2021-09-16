using System;

namespace Divide_By_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Give me a number to divide: ");
                int number = int.Parse(Console.ReadLine());
                Divide(number);
            } while (true);
        }
        static int Divide(int number)
        {
            int result;
            try
            {
                result = 10 / number;
                Console.WriteLine($"10 / {number} = {result}");           
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fail");
                return result = -1;
            }
            return result;
        }
    }
}
