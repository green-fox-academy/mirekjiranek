using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    [Route("gfa")]
    public class StudentController : Controller
    {
        private StudentService sc;

        public StudentController(StudentService sc)
        {
            this.sc = sc;
        }
        [HttpGet("list")]
        public IActionResult StudentsList()
        {
            return View(sc);
        }
        [HttpGet("add")]
        public IActionResult AddStudent()
        {
            return View(sc);
        }
        [HttpGet("save")]
        public IActionResult SaveStudent([FromQuery]string new_student)
        {
            sc.Save(new_student);
            return RedirectToAction("StudentsList",sc);
        }
        [HttpGet("check")]
        public IActionResult CheckStudent()
        {
            return View(sc);
        }
        [HttpGet("checked")]
        public IActionResult CheckedStudent([FromQuery] string check_student)
        {
            return View(sc.Check(check_student));
        }
    }
}
