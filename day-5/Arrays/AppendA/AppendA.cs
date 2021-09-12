using System;

namespace AppendA
{
    class AppendA
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content:
            //   `["koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
            //     "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"]`
            //
            // - Add all elements an `"a"` at the end
            string[] animals = { "koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill", "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn" };

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i] + "a");
            }
        }
    }
}
