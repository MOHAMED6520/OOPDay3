using OOPDay3.InterfaceEX01;
using OOPDay3.InterfaceEx02;

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


        }
    }
}
