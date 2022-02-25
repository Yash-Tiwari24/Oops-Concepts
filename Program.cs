using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraction
            Circle c1 = new Circle();
            double area = Circle.Area(22);
            Console.WriteLine(area);

            Square s1 = new Square(10);
            Console.WriteLine(s1.Area());

        }
    }
}
