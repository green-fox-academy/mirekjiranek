using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class DbLogs
    {
        public List<Log> Logs { get; set; }
        public int EntryCount { get; set; }
    }
}
