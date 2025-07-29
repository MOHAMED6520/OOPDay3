using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEx02
{
    internal class SeriesBy3:ISeries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 3;
        }

       
    }
}
