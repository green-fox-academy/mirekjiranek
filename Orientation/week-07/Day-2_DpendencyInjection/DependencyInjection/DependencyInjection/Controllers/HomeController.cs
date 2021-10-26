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
        private CaesarCoding cc;
        public HomeController(UtilityService us,CaesarCoding cc)
        {
            this.us = us;
            this.cc = cc;
        }
        [HttpGet("{text}/{shift}")]
        public IActionResult Encode_Decode(string text, int shift)
        {
            ViewBag.CaesarInput = text;
            if(shift >= 0)
            {
                ViewBag.CaesarResult = cc.Caesar(text, shift);
            }
            else
            {
                ViewBag.CaesarResult = cc.Caesar(text, shift);
            }
            return View("MainPage");
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
