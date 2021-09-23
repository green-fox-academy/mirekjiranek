using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsToStringedInstruments
{
   public  class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(string name, int numberOfStrings) : base(name, numberOfStrings) 
        {
            this.NumberOfStrings = 6;
        }
        public override void Sound()
        {
            Console.WriteLine("Twang");
        }
    }
}
