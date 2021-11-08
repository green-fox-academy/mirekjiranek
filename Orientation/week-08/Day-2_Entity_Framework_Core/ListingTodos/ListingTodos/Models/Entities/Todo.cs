using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models.Entities
{
    public class Todo
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public long? AssigneeId { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public Todo()
        {
            CreatedDateTime = DateTime.Now;
        }
        public Assignee Assignee { get; set; }
    }
}
