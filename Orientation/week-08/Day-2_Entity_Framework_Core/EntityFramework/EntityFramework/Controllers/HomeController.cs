using EntityFramework.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private UserService UserService { get; }
        public HomeController(UserService service)
        {
            UserService = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
