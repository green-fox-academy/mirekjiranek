using ListingTodos.Models;
using ListingTodos.Models.Entities;
using ListingTodos.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Controllers
{
    [Route("assignee")]
    public class AssigneeController : Controller
    {
        public AssigneeService Service { get; }
        public TodoService TodoService { get; }
        public AssigneeController(AssigneeService service, TodoService todoService)
        {
            Service = service;
            TodoService = todoService;
        }
        [HttpGet]
        public IActionResult ListOfAssignees()
        {
            var viewModel = new AssigneeViewModel() { AllAssignees = Service.FindAll().ToList() };
            return View(viewModel);
        }
        [HttpGet("{id:long}")]
        public IActionResult Delete([FromRoute] long id)
        {
            Service.Delete(id);
            return RedirectToAction("ListOfAssignees");
        }
        [HttpGet("{id:long}/edit")]
        public IActionResult EditAssignee([FromRoute] long id)
        {
            var ViewModel = new AssigneeViewModel() { Assignee = Service.FindById(id) };
            return View("Edit", ViewModel);
        }
        [HttpPost("{id:long}/edit")]
        public IActionResult EditAssignee([FromForm] Assignee assignee)
        {
            Service.Update(assignee);
            return RedirectToAction("ListOfAssignees");
        }
        [HttpGet("{id:long}/listoftodos")]
        public IActionResult ListOfTodos([FromRoute] long id)
        {
            var ViewModel = new AssigneeViewModel() { AllTodos = TodoService.FindTodosByAssignee(id), Assignee = Service.FindById(id) };
            return View(ViewModel);
        }
        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("Add");
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] Assignee assignee)
        {
            var savedAssignee = Service.Add(assignee);
            return RedirectToAction("ListOfAssignees");
        }
    }
}
