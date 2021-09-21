using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        int counter = 0;

        public Counter(int counter)
        {
            this.counter = counter;
        }

        public Counter()
        {

        }

        public void Add(int number)
        {
            counter = counter + number;
            Console.WriteLine(counter);
        }

        public void Add()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public void Get()
        {
            Console.WriteLine(counter);
        }

        public void Reset()
        {
            counter = 0;
        }

    }
}
