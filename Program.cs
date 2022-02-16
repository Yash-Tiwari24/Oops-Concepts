using Oops_Concepts.Opps_Concepts;
using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var newaccount = new BankAccount("Yash Tiwari", 10000);
            Console.WriteLine($"Account Number {newaccount.Number} was created for {newaccount.Owner} with {newaccount.Balance} initial balance.");
        }
    }
}
