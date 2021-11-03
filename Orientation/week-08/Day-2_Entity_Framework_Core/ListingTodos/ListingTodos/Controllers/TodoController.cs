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
    [Route("todo")]
    public class TodoController : Controller
    {
        private TodoService TodoService { get; }
        public TodoController(TodoService service)
        {
            TodoService = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var viewModel = new TodoViewModel() { AllTodos = TodoService.FindAll().ToList() };
            return View(viewModel);
        }
        [HttpGet("{id:long}/edit")]
        public IActionResult EditTodo([FromRoute] long id)
        {
            var TodoViewModel = new TodoViewModel() { Todo = TodoService.FindById(id) };
            return View("Edit",TodoViewModel);
        }
        [HttpPost("{id:long}/edit")]
        public IActionResult EditTodo([FromForm] Todo todo)
        {
            TodoService.Update(todo);
            return RedirectToAction("Index");
        }
        [HttpGet("list/{id:long}")]
        public IActionResult Delete([FromRoute] long id)
        {
            TodoService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("Add");
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] Todo todo)
        {
            var savedTodo = TodoService.Add(todo);
            return RedirectToAction("Index");
        }
    }
}
