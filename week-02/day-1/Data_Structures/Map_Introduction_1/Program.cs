using System.Collections.Generic;
using System;

namespace Map_Introduction_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, char> map = new Dictionary<int, char> 
            {
                {97 , 'a' } , {98 , 'b'} , {99 , 'C'} , {65 , 'A'} , {66 , 'B'} , {67 , 'C'}
            };
            foreach (int i  in map.Keys)
            {
                Console.WriteLine(i);
            }

            foreach (char i in map.Values)
            {
                Console.WriteLine(i);
            }
            map.Add(68, 'D');
            Console.WriteLine(map.Count);
            Console.WriteLine(map[99]);
            map.Remove(97);
            Console.WriteLine(map.ContainsKey(100));
            map.Clear();
            Console.WriteLine(map.Count);
        }
    }
}
