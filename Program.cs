using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num = 2020;

            // boxing
            object obj = num;

            // value of num to be change
            num = 100;

            System.Console.WriteLine
            ("Value - type value of num is : {0}", num);
            System.Console.WriteLine
            ("Object - type value of obj is : {0}", obj);


            // unboxing
            int i = (int)obj;

            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);



        }
    }
}
