using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay3.InterfaceEx02
{
    class EmployeeCompareSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
           Employee X = (Employee)x;
           Employee Y = (Employee)y;
            if (X.Salary>Y.Salary)
                return 1;
            else if (Y.Salary>X.Salary)
                return -1;
            else
                return 0;
        }
    }
    class EmployeeCompareNameLenght : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            if (X.Name.Length > Y.Name.Length)
                return 1;
            else if (Y.Name.Length > X.Name.Length)
                return -1;
            else
                return 0;
        }
    }


    internal class Employee:ICloneable,IComparable
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

        public int CompareTo(object? obj)
        {
            Employee emp = (Employee)obj;
            //if (this.Salary > emp.Salary)
            //    return 1;
            //else if (this.Salary < emp.Salary)
            //    return -1;
            //else return 0 ;
          return  this.Age.CompareTo(emp.Age);
        }
    }
}
