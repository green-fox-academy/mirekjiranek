using System;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {

            SharpieSet Sharpies = new();
            Sharpie sharpie1 = new();
            Sharpie sharpie2 = new();
            Sharpie sharpie3 = new();
            Sharpie sharpie4 = new();

            Sharpies.Add(sharpie1);
            Sharpies.Add(sharpie2);
            Sharpies.Add(sharpie3);
            Sharpies.Add(sharpie4);




            sharpie1.Use();
            sharpie1.Use();

            sharpie4.Use();
            sharpie4.Use();

            Sharpies.CountUsable();
            Sharpies.RemoveTrash();



        }
    }
}
