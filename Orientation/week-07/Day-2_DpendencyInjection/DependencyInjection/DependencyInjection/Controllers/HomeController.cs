using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [Route("useful")]
    public class HomeController : Controller
    {
        private UtilityService us;
        public HomeController(UtilityService us)
        {
            this.us = us;
        }
        [HttpGet("colored")]
        public IActionResult Index()
        {     
            return View(us);
        }
        [HttpGet("email")]
        public IActionResult EmailValid([FromQuery]string email)
        {
            if (us.ValidateEmail(email))
            {
                ViewBag.bcgcolor = "green";
            }
            else
            {
                ViewBag.bcgcolor = "red";
            }
            return View();
        }
    }
}
