using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using FoxClub.Model;

namespace FoxClub.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public FoxServices Service { get; set; }
        public HomeController(FoxServices service)
        {
            Service = service;
        }
        public IActionResult Index([FromQuery] string name)
        {
            if (name == null || name == "")
            {
                return RedirectToAction("login");
            }

            return View(Service.FindFox(name));
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            Service.Save(name);
            return RedirectToAction("Index",new { name = name });
        }
    }
}
