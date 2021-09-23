using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsToStringedInstruments
{
   public  class Violin : StringedInstrument
    {
        public Violin(string name, int numberOfStrings) : base(name, numberOfStrings) 
        {
            this.NumberOfStrings = 4;
        }
        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
    }
}
