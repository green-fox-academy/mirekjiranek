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
                {"978-1-60309-461-0" , "The Lab"}
            };

            foreach (KeyValuePair<string, string> pair in map)
            {
                Console.WriteLine(pair.Value + "(ISBN: " + pair.Key + ")");
            }
            map.Remove("978-1-60309-444-3");

            foreach (KeyValuePair<string, string> pair in map)
            {
                if (pair.Value == "The Lab")
                {
                    map.Remove(pair.Key);
                }
            }

            map.Add("978-1-60309-450-4","They Called Us Enemy");
            map.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            Console.WriteLine(map.TryGetValue("478-0-61159-424-8",out string value));

            Console.WriteLine(map.TryGetValue("978-1-60309-453-5",out string newvalue));


        }
    }
}
