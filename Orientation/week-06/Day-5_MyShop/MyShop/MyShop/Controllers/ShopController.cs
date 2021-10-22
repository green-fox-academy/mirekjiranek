using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Controllers
{
    [Route("")]
    public class ShopController : Controller
    {
        private static List<ShopItem> ShopItems;
        static ShopController()
        {
            ShopItems = new List<ShopItem>();
            ShopItems.Add(new ShopItem()
            {
                Name = "Running Shoes",
                Description = "Nike running shoes for every day sport",
                Price = 1000.0,
                QuantityOfStock = 5,
                Type = "Clothes and shoes"
            });
            ShopItems.Add(new ShopItem()
            {
                Name = "Printer",
                Description = "Some HP printer what will print pages",
                Price = 3000.0,
                QuantityOfStock = 2,
                Type = "Electronics"
            });
            ShopItems.Add(new ShopItem()
            {
                Name = "Coca Cola",
                Description = "0.5l standard coke",
                Price = 25.0,
                QuantityOfStock = 0,
                Type = "Beverages and Snacks"
            });
            ShopItems.Add(new ShopItem()
            {
                Name = "Wokin",
                Description = "Chicken with rice and WOKIN sauce",
                Price = 119.0,
                QuantityOfStock = 100,
                Type = "Beverages and snacks"
            });
            ShopItems.Add(new ShopItem()
            {
                Name = "T-shirt",
                Description = "Blue with a corgi on a bike",
                Price = 300.0,
                QuantityOfStock = 1,
                Type = "Clothes and shoes"
            });
        }
        [HttpGet("webshop")]
        public IActionResult Index()
        {
            return View(new ShopItemsListViewModel()
            {
                AllShopItems = ShopItems
            });
        }
        [HttpGet("only-available")]
        public IActionResult OnlyAval()
        {
            ShopItemsListViewModel AvalaibleItems = new ShopItemsListViewModel();
            AvalaibleItems.AllShopItems = ShopItems.Where(a => a.QuantityOfStock > 0).ToList();
            return View("Index", AvalaibleItems);
        }
        [HttpGet("cheapest-first")]
        public IActionResult CheapestFirst()
        {
            ShopItemsListViewModel CheapestFirst = new ShopItemsListViewModel();
            CheapestFirst.AllShopItems = ShopItems.OrderBy(a => a.Price).ToList();
            return View("Index", CheapestFirst);
        }
        [HttpGet("contains-nike")]
        public IActionResult ContainsNike()
        {
            ShopItemsListViewModel ContainsNike = new ShopItemsListViewModel();
            ContainsNike.AllShopItems = ShopItems.Where(a => a.Name.ToLower().Contains("nike") || a.Description.ToLower().Contains("nike")).ToList();
            return View("Index", ContainsNike);
        }
        [HttpGet("average-stock")]
        public IActionResult AverageStock()
        {
            ShopItemsListViewModel AvgStock = new ShopItemsListViewModel();
            AvgStock.Info = ShopItems.Average(a => a.QuantityOfStock).ToString();
            return View("AverageStock", AvgStock);
        }
        [HttpGet("most-expensive-avalaible")]
        public IActionResult MostExpensiveAvailable()
        {
            ShopItemsListViewModel MostExpensiveAvailable = new ShopItemsListViewModel();
            MostExpensiveAvailable.AllShopItems = ShopItems.Where(a => a.QuantityOfStock > 0).OrderByDescending(a => a.Price).ToList();
            return View("Index", MostExpensiveAvailable);
        }
        [HttpPost("search")]
        public IActionResult SearchFor(string product)
        {
            ShopItemsListViewModel SearchFor = new ShopItemsListViewModel();
            SearchFor.AllShopItems = ShopItems.Where(a => a.Name.ToLower().Contains(product.ToLower()) ||
            a.Description.ToLower().Contains(product.ToLower())).ToList();
            return View("Index", SearchFor);
        }
        [HttpGet("clothes-and-shoes")]
        public IActionResult ClothesAndShoes()
        {
            ShopItemsListViewModel ClothesAndShoes = new ShopItemsListViewModel();
            ClothesAndShoes.AllShopItems = ShopItems.Where(a => a.Type == "Clothes and shoes").ToList();
            return View("Index", ClothesAndShoes);
        }
        [HttpGet("Electronics")]
        public IActionResult Electronics()
        {
            ShopItemsListViewModel Electronics = new ShopItemsListViewModel();
            Electronics.AllShopItems = ShopItems.Where(a => a.Type =="Electronics").ToList();
            return View("Index", Electronics);
        }
        [HttpGet("beverages-and-snacks")]
        public IActionResult BeveragesAndSnacks()
        {
            ShopItemsListViewModel BeveragesAndSnacks = new ShopItemsListViewModel();
            BeveragesAndSnacks.AllShopItems = ShopItems.Where(a => a.Type == "Beverages and Snacks").ToList();
            return View("Index", BeveragesAndSnacks);
        }
        //[HttpGet("euro")]
        //public IActionResult euro()
        //{
        //    ShopItemsListViewModel euro = new ShopItemsListViewModel();
        //    euro.AllShopItems = ShopItems.Where().Tolist();
        //    return View("Index", euro);
        //}
        //[HttpGet("original-currency")]
        //public IActionResult OriginalCurrency()
        //{
        //    ShopItemsListViewModel OriginalCurrency = new ShopItemsListViewModel();
        //    OriginalCurrency.AllShopItems = ShopItems.Where().Tolist();
        //    return View("Index", OriginalCurrency);
        //}

    }
}
