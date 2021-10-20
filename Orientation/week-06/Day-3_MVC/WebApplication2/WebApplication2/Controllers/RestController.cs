using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        static long Count = 1;
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("greeting")]
        public Greeting Greet([FromQuery]string name)
        {

            return new Greeting(Count++, "Hello " + name);
        }
    }
}
