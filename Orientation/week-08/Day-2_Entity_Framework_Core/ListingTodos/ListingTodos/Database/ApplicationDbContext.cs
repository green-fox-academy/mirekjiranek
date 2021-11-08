using ListingTodos.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignee>()
                .HasMany<Todo>(a => a.TodoTasks)
                .WithOne(u => u.Assignee)
                .HasForeignKey(a => a.AssigneeId)
                .IsRequired(false);
        }
    }
}
