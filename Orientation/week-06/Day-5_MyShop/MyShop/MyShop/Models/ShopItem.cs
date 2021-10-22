using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityOfStock { get; set; }
        public string Type { get; set; }
    }
}
