using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEx03
{
    internal class Plane:IMoveable,IFlyable
    {
         int IMoveable.Speed { get; set; }

         void IMoveable.Backward()
        {
            Console.WriteLine("Plane IMoveable Backward");
        }

         void IMoveable.Forward()
        {
            Console.WriteLine("Plane IMoveable Forward");
        }

         void IMoveable.Left()
        {
            Console.WriteLine("Plane IMoveable Left");
        }

         void IMoveable.Right()
        {
            Console.WriteLine("Plane IMoveable Right");
        }

        int IFlyable.Speed { get; set; }

        void IFlyable.Backward()
        {
            Console.WriteLine("Plane IFlyable Backward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Plane IFlyable Forward");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Plane IFlyable Left");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Plane IFlyable Right");
        }
    }
}
