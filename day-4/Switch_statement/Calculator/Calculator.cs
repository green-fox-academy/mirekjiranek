using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.Write("Please provide the first number:");
            string num1 = Console.ReadLine();
            double num1Double = double.Parse(num1);

            // Get the first number:
            // int number1 = ...

            Console.Write("Please provide the second number:");
            string num2 = Console.ReadLine();
            double num2Double = double.Parse(num2);
            // Get the second number:
            // int number2 = ...

            Console.Write("Please provide the operation (add, substract, multiply or divide):");
            string operation = Console.ReadLine();

            // Get the operation from standard input:
            // string operation = ...

            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable

            double result = 0.0;

            switch (operation)
            {
                case "add":
                    result = num1Double + num2Double;
                    break;
                case "substract":
                    result = num1Double - num2Double;
                    break;
                case "multiply":
                    result = num1Double * num2Double;
                    break;
                case "divide":
                    result = num1Double / num2Double;
                    break;
                default:
                    Console.WriteLine("None of above operations selected.");
                    break;
            }

            Console.WriteLine($"The result of the calculation is {result}");
        }
    }
}
