using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsToStringedInstruments
{
     class BassGuitar : StringedInstrument
    {

        public BassGuitar(string name) : base(name) 
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Duum-duum-duum");
        }
    }
}
