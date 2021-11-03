using ListingTodos.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class TodoViewModel
    {
        public Todo Todo { get; set; }
        public List<Todo> AllTodos { get; set; }
    }
}
