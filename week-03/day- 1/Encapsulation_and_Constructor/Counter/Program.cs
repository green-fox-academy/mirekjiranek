using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter number = new();
            Counter number1 = new(15);
            number.Add();
            number1.Add(3);
            number.Get();
            number1.Get();
            number1.Reset();
            number1.Get();

        }
    }
}
