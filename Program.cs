using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "i am yash tiwari";
            //Console.WriteLine(str.WordCount());

            //foreach (var item in str.SplitString())
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in str.ToCharArray())
            {
                Console.WriteLine(item);
            }

            Student student = new Student()
            {
                FirstName = "Yash",
                LastName = "Tiwari"
            };

            student.print();
            

        }
    }
}
