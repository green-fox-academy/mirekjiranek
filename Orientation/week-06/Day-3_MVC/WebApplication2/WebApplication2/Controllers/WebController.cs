using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        static long Count = 1;
        [HttpGet("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            var greeting = new Greeting(Count++, name);
            return View(greeting);
        }
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            var hello = new Hello();
            return View(hello);
        }
    }
}
