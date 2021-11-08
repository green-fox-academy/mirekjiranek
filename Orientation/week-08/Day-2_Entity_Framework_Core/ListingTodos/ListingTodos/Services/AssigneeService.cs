using ListingTodos.Database;
using ListingTodos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public class AssigneeService
    {
        private ApplicationDbContext DbContext { get; }
        public AssigneeService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public Assignee FindById(long id)
        {
            return DbContext.Assignees.Find(id);
        }
        public List<Assignee> FindAll()
        {
            return DbContext.Assignees.ToList();
        }
        public void Delete(long id)
        {
            DbContext.Assignees.Remove(FindById(id));
            DbContext.SaveChanges();
        }
        public void Update(Assignee assignee)
        {
            DbContext.Assignees.Update(assignee);
            DbContext.SaveChanges();
        }
        public Assignee Add(Assignee assignee)
        {
            var savedAssignee = DbContext.Assignees.Add(assignee).Entity;
            DbContext.SaveChanges();
            return savedAssignee;
        }

    }
}
