using System;
using System.Collections.Generic;
using System.Linq;
using static Oops_Concepts.Records;

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

            string WaterState(int? tempInFahrenheit) =>
                tempInFahrenheit switch
                {
                    (> 32) and (< 212) => "liquid",
                    < 32 => "solid",
                    > 212 => "gas",
                    32 => "solid/liquid transition",
                    212 => "liquid / gas transition",
                };
            Console.WriteLine(nameof(WaterState));

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

            decimal CalculateDiscount(Order order) => order switch
            {
                (Items: > 10, Cost: > 1000.00m) => 10.5m,
                (Items: > 5, Cost: > 500.00m) => 5.5m,
                Order { Cost: > 250.00m } => 2.5m,
                null => throw new ArgumentNullException(nameof(order), "Can't calculate discount on null order"),
                var someObject => 0m,
            };

            Order order = new Order(11, 1888);
            Console.WriteLine(CalculateDiscount(order));

        }


    }
}
