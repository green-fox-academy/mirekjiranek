using ListingTodos.Database;
using ListingTodos.Models.Entities;
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
            return DbContext.Todos.Find(id);
        }
        public List<Todo> FindAll()
        {
            var neco = DbContext.Todos.ToList();
            return DbContext.Todos.ToList();
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
    }
}
