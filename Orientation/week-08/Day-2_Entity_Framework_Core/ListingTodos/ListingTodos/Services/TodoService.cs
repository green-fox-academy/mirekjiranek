using ListingTodos.Database;
using ListingTodos.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public class TodoService
    {
        private ApplicationDbContext DbContext { get; }
        public TodoService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public Todo FindById(long id)
        {
            return DbContext.Todos.Include(t => t.Assignee).FirstOrDefault(i=>i.Id == id);
        }
        public List<Todo> FindAll()
        {
            return DbContext.Todos.Include(t=>t.Assignee).ToList();
        }
        public Todo Add(Todo todo)
        {
            var savedTodo = DbContext.Todos.Add(todo).Entity;
            DbContext.SaveChanges();
            return savedTodo;
        }
        public void Delete(long id)
        {
            DbContext.Todos.Remove(FindById(id));
            DbContext.SaveChanges();
        }
        public void Update(Todo todo)
        {
            DbContext.Todos.Update(todo);
            DbContext.SaveChanges();
        }
        public List<Todo> Search(string searchingWord)
        {
            return DbContext.Todos.Where(t => t.Title.ToLower().Contains(searchingWord.ToLower()) || t.Description.ToLower().Contains(searchingWord.ToLower())).ToList();
        }
        public List<Todo> FindTodosByAssignee(long id)
        {
            return FindAll().Where(a => a.AssigneeId == id).ToList();
        }

    }
}
