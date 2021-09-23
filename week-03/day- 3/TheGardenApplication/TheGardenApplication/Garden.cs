using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGardenApplication
{
    class Garden
    {
        List<Flower> Flowers;
        List<Tree> Trees;

        public Garden()
        {
            Trees = new List<Tree>();
            Flowers = new List<Flower>();


        }

        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }
        public void AddTree(Tree tree)
        {
            Trees.Add(tree);
        }
        public void Watering()
        {
            int WaterMe = 0;
            bool isFirstWatering = true;
            for (int i = 0 ;i < Flowers.Count; i++)
            {
                if (Flowers[i].DoYouNeedWater() == true)
                {
                    WaterMe++;
                }               
            }
            for (int i = 0; i < Trees.Count; i++)
            {
                if (Trees[i].DoYouNeedWater() == true)
                {
                    WaterMe++;
                }
            }
            for (
        }
    }
}
