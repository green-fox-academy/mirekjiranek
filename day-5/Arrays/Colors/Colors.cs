﻿using System;

namespace Colors
{
    class Colors
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
            string[][] colors = new string[2][];
            colors[0] = new string[5] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new string[3] { "orange red", "red", "tomato" };
            colors[2] = new string[4] { "orchid", "violet", "pink", "hot pink"};


        }
    }
}
