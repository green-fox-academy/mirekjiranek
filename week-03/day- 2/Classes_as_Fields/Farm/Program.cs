using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm animals = new Farm();

            Animal lyon = new Animal("lyon");
            Animal gyraphe = new Animal("gyraphe");
            Animal zebra = new Animal("zebra");
            Animal frog = new Animal("frog");

            animals.Breed(zebra);
            animals.Breed(lyon);
            animals.Breed(gyraphe);
            animals.Breed(frog);

            animals.Sell();
            animals.Sell();



        }
    }
}
