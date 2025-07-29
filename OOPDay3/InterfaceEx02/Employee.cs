using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEx02
{
    internal class Employee:ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
                
        }
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Age = emp.Age;
            Salary = emp.Salary;

        }
        public object Clone()
        {
            return new Employee(this) ;
        }

        public override string ToString()
        {
            return $"Id : {Id} ::Name : {Name} :: Age {Age} :: Salary {Salary}  ::  ";
        }

    }
}
