using System;
using System.Collections.Generic;
using System.Linq;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            int? maybe =null;

            if (maybe is int number)
            {
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            }
            else
            {
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
            }

            string? message = "This is not the null string";
            if(message is not null)
            {
                Console.WriteLine(message);
            }

            Student student = new Student();
            if(student is Student)
            {
                Console.WriteLine(student.Name);
            }

            string WaterState(int tempInFahrenheit) =>
                tempInFahrenheit switch
                {
                    (> 32) and (< 212) => "liquid",
                    < 32 => "solid",
                    > 212 => "gas",
                    32 => "solid/liquid transition",
                    212 => "liquid / gas transition",
                };
            Console.WriteLine(WaterState(32));

            int[] numberList = { 11,12,13,14,15,16,17,18 };
            Console.WriteLine(StaticMethods.MidPoint(numberList));
            Console.WriteLine(StaticMethods.MidPoint(new List<int> { 11, 12, 13, 14, 15, 16, 17, 18}));
            try
            {
                Console.WriteLine(StaticMethods.MidPoint(new List<int> { }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
