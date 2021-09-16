using System;

namespace DefineBasicInfo
{
    class DefineBasicInfo
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            string name = "Miroslav";
            // Your age as an integer
            int age = 24;
            // Your height in meters as a double
            double height = 1.87;
            // Whether you are married or not as a boolean
            bool married = false;

            Console.WriteLine($"My name is {name}, I'm {age} years old, I'm {height}m high and its {married} when you say that I'm married");
        }
    }
}
