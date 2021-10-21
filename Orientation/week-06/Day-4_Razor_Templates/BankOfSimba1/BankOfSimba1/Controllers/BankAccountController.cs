using Microsoft.AspNetCore.Mvc;
using BankOfSimba1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba1.ViewModels;

namespace BankOfSimba1.Controllers
{
    [Route("")]
    public class BankAccountController : Controller
    {
        private static List<BankAccount> animals;
        static BankAccountController()
        {
            animals = new List<BankAccount>();
            animals.Add(new BankAccount()
            {
                Name = "Kovu",
                Balance = 1900.145.ToString("0.00"),
                AnimalType = "lion",
                IsBad = false
            });
            animals.Add(new BankAccount()
            {
                Name = "Banzai",
                Balance = 1000.145.ToString("0.00"),
                AnimalType = "hyena",
                IsBad = true
            });
            animals.Add(new BankAccount()
            {
                Name = "Beshte",
                Balance = 1600.05.ToString("0.00"),
                AnimalType = "hippo",
                IsBad = true
            });
            animals.Add(new BankAccount()
            {
                Name = "Pumbaa",
                Balance = 500.00.ToString("0.00"),
                AnimalType = "pig",
                IsBad = false
            });
            animals.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000.597.ToString("0.00"),
                AnimalType = "lion"
            });
        }
        [HttpGet("show")]
        public IActionResult Index()
        {
            return View(new AnimalsListViewModel() {
            AnimalsAccounts = animals});
        }
        [HttpGet("raw")]
        public IActionResult Raw()
        {
            string raw = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View("Raw", raw);
        }

    }
}
