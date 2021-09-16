using System;
using System.Collections.Generic;

namespace Map_Introduction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> map = new Dictionary<string, string>
            {
                {"978-1-60309-452-8" , "A Letter to Jo"} ,
                {"978-1-60309-459-7" , "Lupus"} ,
                {"978-1-60309-444-3" , "Red Panda and Moon Bear"} ,
                {"978-1-60309-461-0	" , "The Lab"}
            };
            string value;
            Console.WriteLine(map["978-1-60309-452-8"] + "(ISBN: " + map. + ")");

        }
    }
}
