﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEx03
{
    internal interface IMoveable
    {
         int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }
}
