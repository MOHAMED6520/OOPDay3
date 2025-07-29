using OOPDay3.InterfaceEX01;
using OOPDay3.InterfaceEx02;
using OOPDay3.InterfaceEx03;
using System.Text;

namespace OOPDay3
{
    internal class Program
    {
        #region InterfaceEx02
        //static void Print10Number (SeriesByTwo seriesbytwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{seriesbytwo.Current} ");
        //        seriesbytwo.Next();
        //    }
        //    Console.WriteLine();
        //    seriesbytwo.Reset();
        //}
        //static void Print10Number(SeriesBy3 seriesbytwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{seriesbytwo.Current} ");
        //        seriesbytwo.Next();
        //    }
        //    Console.WriteLine();
        //    seriesbytwo.Reset();
        //}
        //static void Print10Number(SeriesBy4 seriesbytwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{seriesbytwo.Current} ");
        //        seriesbytwo.Next();
        //    }
        //    Console.WriteLine();
        //    seriesbytwo.Reset();
        //}

        //static void Print10Number(ISeries seriesbytwo)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{seriesbytwo.Current} ");
        //        seriesbytwo.Next();
        //    }
        //    Console.WriteLine();
        //    seriesbytwo.Reset();
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region InterfaceEx01
            ////MyType myType = new MyType();
            ////myType.Salary = 15000;
            ////Console.WriteLine(myType.Salary);
            ////myType.MyFun();

            //IMyType myType = new MyType();

            //myType.Salary = 1032101;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();
            //myType.Print(); 
            #endregion

            #region InterfaceEx02

            ////SeriesByTwo seriesbytwo = new SeriesByTwo();
            ////SeriesBy3 seriesby3 = new SeriesBy3();
            ////SeriesBy4 seriesby4 = new SeriesBy4();
            ////Print10Number(seriesby4);

            ////int[] arr = { 10, 2, 4, 5, 36, 7, 8, 0 };
            ////Array.Sort(arr);

            ////foreach (int item in arr)
            ////{  Console.Write($"{item} "); }

            //Employee[] employees = new Employee[3]
            //{
            //new Employee(){Id =1 , Name = "Mohamed" , Age = 25 , Salary = 15000},
            //new Employee(){Id =2 , Name = "Ali" , Age = 24 , Salary = 12000},
            //new Employee(){Id =3 , Name = "Ahmed" , Age = 26 , Salary = 11000}
            //};

            //Array.Sort(employees);

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region InterfaceEx03
            //Car car = new Car();

            //car.Speed = 100;
            //car.Backward();

            //Plane plane = new Plane();
            //IMoveable moveable = plane;
            //moveable.Backward();
            //IFlyable flyable = plane;
            //flyable.Backward(); 
            #endregion

            #region Shallo Copy Vs Deep Copy
            //Shallo Copy Vs Deep Copy
            //int[] Arr1 = { 1, 2, 3 };
            //int[] Arr2 = { 4, 5, 6 };
            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Console.WriteLine();

            //Arr2 = Arr1;
            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());

            //Arr2[0] = 100;
            //Console.WriteLine(Arr1[0]);

            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Console.WriteLine();

            //Arr2 = (int[]) Arr1.Clone();
            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());

            //Arr2[0] = 100;
            //Console.WriteLine(Arr1[0]);

            //string [] Arr1 = { "a","b","c" };
            //string [] Arr2 = { "d","e","f" };

            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Console.WriteLine();

            //Arr2 = Arr1;
            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Arr2[0] += "mjh";
            //Console.WriteLine(Arr1[0]);


            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Console.WriteLine();

            //Arr2 = (string[])Arr1.Clone();
            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Arr2[0] += "mjh";
            //Console.WriteLine(Arr1[0]);

            //StringBuilder[] Arr1 = new StringBuilder[]
            //    {
            //        new StringBuilder("Ahmed"),
            //        new StringBuilder("Ali"),
            //        new StringBuilder("Mohamed")
            //    };

            //StringBuilder[] Arr2 = new StringBuilder[]
            //   {
            //        new StringBuilder("Amr"),
            //        new StringBuilder("Ziad"),
            //        new StringBuilder("Arfa")
            //   };

            ////Console.WriteLine(Arr1.GetHashCode());
            ////Console.WriteLine(Arr2.GetHashCode());
            ////Console.WriteLine();

            ////Arr2 = Arr1;
            ////Console.WriteLine(Arr1.GetHashCode());
            ////Console.WriteLine(Arr2.GetHashCode());
            ////Arr1[0].Append(" mo ");
            ////Console.WriteLine(Arr2[0]);
            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Console.WriteLine();

            //Arr2 = (StringBuilder[])Arr1.Clone();
            //Console.WriteLine(Arr1.GetHashCode());
            //Console.WriteLine(Arr2.GetHashCode());
            //Arr1[0].Append(" mo ");
            //Console.WriteLine(Arr2[0]); 
            #endregion

            #region Icloneable
            //////Built In Intrface
            //////Icloneable
            ////Employee Emp01 = new Employee() { Id = 1, Name = "Mohamed", Age = 30, Salary = 20200 };
            ////Employee Emp02 = new Employee() { Id = 2, Name = "Ahmed", Age = 25, Salary = 21200 };
            //////Emp02= Emp01;
            ////Console.WriteLine(Emp02);
            ////Console.WriteLine(Emp01.GetHashCode());
            ////Console.WriteLine(Emp02.GetHashCode());
            ////Emp02 = (Employee)Emp01.Clone();
            ////Console.WriteLine(Emp01);
            ////Console.WriteLine(Emp01.GetHashCode());
            ////Console.WriteLine(Emp02.GetHashCode());
            ////Emp02 = new Employee(Emp01);
            #endregion

            #region IComparable
            //IComparable

            //Employee[] employees = new Employee[3]
            //{
            //new Employee(){Id =1 , Name = "Mohamed" , Age = 25 , Salary = 15000},
            //new Employee(){Id =2 , Name = "Ali" , Age = 24 , Salary = 12000},
            //new Employee(){Id =3 , Name = "Ahmed" , Age = 26 , Salary = 11000}
            //};

            //Array.Sort(employees);

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region IComparer
            //IComparer

            //Employee[] employees = new Employee[3]
            //{
            //new Employee(){Id =1 , Name = "Mohamed" , Age = 25 , Salary = 15000},
            //new Employee(){Id =2 , Name = "Ali" , Age = 24 , Salary = 12000},
            //new Employee(){Id =3 , Name = "Ahmed" , Age = 26 , Salary = 11000}
            //};

            //Array.Sort(employees,new EmployeeCompareNameLenght () );

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
