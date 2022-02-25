using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static or Compile Time Polymorphism 
            Calculate dataClass = new Calculate();
            int add2 = dataClass.Add(45, 34, 67);
            int add1 = dataClass.Add(23, 34);

            Console.WriteLine(add2);
            Console.WriteLine(add1);



            //Dynamic or Runtime Polymorphism
            Drawing circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());
        }
    }
}
