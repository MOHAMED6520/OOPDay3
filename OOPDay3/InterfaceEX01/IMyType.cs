using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEX01
{
    internal interface IMyType
    {
        void MyFun();
        
        double Salary { get; set; }

        void Print()
        { Console.WriteLine("Default Implement Methoud [Fully Implemnted Methoud]"); 
        }




    }
}
