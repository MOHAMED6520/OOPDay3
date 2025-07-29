using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEX01
{
    internal class MyType : IMyType , IComparable
    {
        public double Salary { get ; set; }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public void MyFun()
        {
            Console.WriteLine("Hello World"); 
        }
    }
}
