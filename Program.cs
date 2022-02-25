using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoEncap obj = new DemoEncap();
            obj.Name = "Govinda";
            obj.Age = 21;
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}
