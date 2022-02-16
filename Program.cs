using Oops_Concepts.Opps_Concepts;
using System;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Yash Tiwari", 10000);
            Console.WriteLine($"Account Number {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);



            //// Test for a negative balance.
            //try
            //{
            //    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}


            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
