using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate dataClass = new Calculate();
            int add2 = dataClass.Add(45, 34, 67);
            int add1 = dataClass.Add(23, 34);

            Console.WriteLine(add2);
            Console.WriteLine(add1);
        }
    }
}
