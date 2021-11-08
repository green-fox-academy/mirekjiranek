﻿using Frontend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Database
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Log> Logs {get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
