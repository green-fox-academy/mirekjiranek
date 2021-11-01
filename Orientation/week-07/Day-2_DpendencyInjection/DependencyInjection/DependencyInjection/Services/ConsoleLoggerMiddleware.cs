using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        //private Printer printer;
        private Icolor Icolor;
        public ConsoleLoggerMiddleware(Icolor Icolor)
        {
            this.Icolor = Icolor;
        }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Icolor.PrintColor("It is red in color..");

            return next(context);
        }
    }
}
