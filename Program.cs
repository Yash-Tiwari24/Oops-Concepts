using System;

namespace Oops_Concepts
{
    class Program
    {

        int a, b;
     

        static void Main(string[] args)
        {
            Program obj = new Program();// default Constructor
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
           

       


            employee emp1 = new employee("Vithal", 23);  //Parameterized Constructor
            employee emp2 = new employee(emp1);          // copy Constructor
            Console.WriteLine(emp2.Details);

            employee.Salary(); //static Constructor only access static method



            // Counter aCounter = new Counter();   // Error private Constructor
            Counter.currentview = 500;
            Counter.visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
           


        }
    }
}
