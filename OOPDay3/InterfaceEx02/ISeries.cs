using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEx02
{
    internal interface ISeries
    {

        public int Current { get; set; }

        void Next();

        public void Reset()
        {
            Current = 0;
        }
    }
}
