using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsToStringedInstruments
{
   public abstract class Instrument
    {
        protected string name;

        protected Instrument(string name)
        {
            this.name = name;
        }

        public abstract void Play();
    }
}
