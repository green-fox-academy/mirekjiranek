using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class RedColor : Icolor
    {
        private Printer printer;
        public RedColor(Printer printer)
        {
            this.printer = printer;
        }
        public void PrintColor(string message)
        {
            printer.Log(message);
        }
    }
}
