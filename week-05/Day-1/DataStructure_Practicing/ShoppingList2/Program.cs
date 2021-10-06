using System;
using System.Collections.Generic;

namespace ShoppingList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> Products = new Dictionary<string, double>
            {
                ["Milk"] = 1.07,
                ["Rice"] = 1.59,
                ["Eggs"] = 3.14,
                ["Cheese"] = 12.60,
                ["Chicken Breasts"] = 9.40,
                ["Apples"] = 2.31,
                ["Tomato"] = 2.58,
                ["Potato"] = 1.75,
                ["Onion"] = 1.10,
            };
            Dictionary<string, int> BobsList = new Dictionary<string, int>
            {
                ["Milk"] = 3,
                ["Rice"] = 2,
                ["Eggs"] = 2,
                ["Cheese"] = 1,
                ["Chicken Breasts"] = 4,
                ["Apples"] = 1,
                ["Tomato"] = 2,
                ["Potato"] = 1,
            };
            Dictionary<string, int> AlicesList = new Dictionary<string, int>
            {
                ["Rice"] = 1,
                ["Eggs"] = 5,
                ["Chicken Breasts"] = 2,
                ["Apples"] = 1,
                ["Tomato"] = 10,
            };
            Console.WriteLine($"Bob payed {BobsShoppingList(Products,BobsList)} in total.");
            Console.WriteLine($"Alice payed {AlicesShoppingList(Products, AlicesList)} in total.");
            Console.WriteLine(WhoBuysMoreRice(BobsList, AlicesList));
            Console.WriteLine(WhoBuysMorePotato(BobsList, AlicesList));
            Console.WriteLine(DifferentProducts(BobsList, AlicesList));
            Console.WriteLine(MoreProducts(BobsList, AlicesList));

        }
        static double BobsShoppingList(Dictionary<string, double> products, Dictionary<string, int> bobslist)
        {
            double sum = 0;
            foreach (KeyValuePair<string, int> s in bobslist)
            {
                foreach (KeyValuePair<string, double> i in products)
                {
                    if (s.Key == i.Key)
                    {
                        sum += s.Value * i.Value;
                    }
                }
            }
            return sum;
        }
        static double AlicesShoppingList(Dictionary<string, double> products, Dictionary<string, int> alicelist)
        {
            double sum = 0;
            foreach (KeyValuePair<string, int> s in alicelist)
            {
                foreach (KeyValuePair<string, double> i in products)
                {
                    if (s.Key == i.Key)
                    {
                        sum += s.Value * i.Value;
                    }
                }
            }
            return sum;
        }
        static string WhoBuysMoreRice(Dictionary<string, int> bobslist, Dictionary<string, int> alicelist)
        {
            if (bobslist["Rice"] < alicelist["Rice"])
            {
                return $"Alice bought more rice({alicelist["Rice"]}) than Bob ({bobslist["Rice"]})";
            }
            else
            {
                return $"Bob bought more rice({bobslist["Rice"]}) than Alice({alicelist["Rice"]}) ";
            }
        }
        static string WhoBuysMorePotato(Dictionary<string, int> bobslist, Dictionary<string, int> alicelist)
        {
            if (!bobslist.ContainsKey("Potato") || !alicelist.ContainsKey("Potato"))
            {
                return "Alice or Bob didnt buy this product.";
            }
            else if (bobslist["Potato"] < alicelist["Potato"])
            {
                return $"Alice bought more potato({alicelist["Potato"]}) than Bob ({bobslist["Potato"]})";
            }
            else
            {
                return $"Bob bought more potato({bobslist["Potato"]}) than Alice ({alicelist["Potato"]})";
            }
        }
        static string DifferentProducts(Dictionary<string, int> bobslist, Dictionary<string, int> alicelist)
        {
            if (bobslist.Count < alicelist.Count)
            {
                return $"Alice bought more products({alicelist.Count}) than Bob ({bobslist.Count})";
            }
            else
            {
                return $"Bob bought more products({bobslist.Count}) than Alice ({alicelist.Count})";
            }
        }
        static string MoreProducts(Dictionary<string, int> bobslist, Dictionary<string, int> alicelist)
        {
            int BobSum = 0;
            int AliceSum = 0;
            foreach (int value in bobslist.Values)
            {
                BobSum += value;
            }
            foreach (int value in alicelist.Values)
            {
                AliceSum += value;
            }
            if (BobSum < AliceSum)
            {
                return $"Alice bought more pieces of products.";
            }
            else
            {
                return $"Bob bought more pieces of products.";
            }
        }
    }
}
