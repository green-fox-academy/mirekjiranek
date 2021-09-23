using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentsToStringedInstruments
{
   public abstract class StringedInstrument : Instrument
    {
        protected int NumberOfStrings;

        protected StringedInstrument(string name, int numberOfStrings) :base(name)
        {
            this.NumberOfStrings = numberOfStrings;
        }

        public override void Play()
        {
            Sound();
        }
        public abstract void Sound();

    }
}
