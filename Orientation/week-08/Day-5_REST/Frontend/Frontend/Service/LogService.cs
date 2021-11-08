using Frontend.Database;
using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Service
{
    public class LogService
    {
        private ApplicationDbContext DbContext { get; }
        public LogService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public Log Add(Log log)
        {
            var savedLog = DbContext.Logs.Add(log).Entity;
            DbContext.SaveChanges();
            return savedLog;
        }
        public DbLogs FindAll()
        {
            DbLogs DbLogs = new();
            DbLogs.Logs = DbContext.Logs.ToList();
            DbLogs.EntryCount = DbContext.Logs.Count();
            return DbLogs;
        }
    }
}
