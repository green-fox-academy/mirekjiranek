using System;

namespace User_input__scanner_
{
    class HelloUser
    {
        static void Main(string[] args)
        {
            // Modify this program to greet the User instead of the World!
            // The program should ask for the name of the User
            Console.Write("Give me your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
