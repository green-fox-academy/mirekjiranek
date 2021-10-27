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
        private EncodeDecodeText ED_Text;
        private EmailValidInfo EV_Info;
        public HomeController(UtilityService us,CaesarCoding cc)
        {
            this.us = us;
            this.cc = cc;
        }
        [HttpGet("{text}/{shift}")]
        public IActionResult Encode_Decode(string text, int shift)
        {
            ED_Text = new EncodeDecodeText(text, cc.Caesar(text, shift));
            return View("MainPage",ED_Text);
        }
        [HttpGet("colored")]
        public IActionResult Index()
        {     
            return View(us);
        }
        [HttpGet("email")]
        public IActionResult EmailValid([FromQuery]string email)
        {
            //if (us.ValidateEmail(email))
            //{
            //    ViewBag.bcgcolor = "green";
            //}
            //else
            //{
            //    ViewBag.bcgcolor = "red";
            //}
            EV_Info = new(email, us.ValidateEmail(email));
            return View("EmailValid", EV_Info);
        }
    }
}
