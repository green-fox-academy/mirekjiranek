using Microsoft.AspNetCore.Mvc;
using FoxClub.Model;
using FoxClub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Controllers
{
    [Route("fox")]
    public class FoxController : Controller
    {
        public FoxServices Service { get; set; }
        public FoxController(FoxServices service)
        {
            Service = service;
        }
        [HttpGet("nutritionStore")]
        public IActionResult NutritionStore(string name)
        {
            return View(Service.FindFox(name));
        }
        [HttpPost("nutritionStore")]
        public IActionResult NutritionStore(string name, string drink, string food)
        {
            Service.UpdateFox(name, drink, food);
            return RedirectToAction("Index", "Home", new { name = name });
        }
        [HttpGet("trickCenter")]
        public IActionResult TrickCenter(string name)
        {
            return View(Service.FindFox(name));
        }
        [HttpPost("trickCenter")]
        public IActionResult TrickCenter(string name, string trick)
        {
            Service.AddTrick(name, trick);
            return RedirectToAction("Index", "Home", new { name = name });
        }
    }
}
