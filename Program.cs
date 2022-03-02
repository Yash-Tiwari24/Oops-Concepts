using Oops_Concepts.Opps_Concepts;
using Oops_Concepts.Repository;
using Oops_Concepts.Services;
using System;

namespace Oops_Concepts
{
    class Program
    {
        private static uint accountNumberSeed = 3245678921;

        static void Main(string[] args)
        {
            

            IBankServices services = new BankServices();

            BankAccount account = new BankAccount {Number=accountNumberSeed,Owner="Yash",Balance=0,};
            accountNumberSeed++;
            Console.WriteLine($"Account Number {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            services.MakeDeposit(10000, DateTime.Now, "Friend paid me back", account);
            services.MakeWithdrawal(500, DateTime.Now, "Paid To Govinda",account);
            Console.WriteLine(account.Balance);
            services.MakeDeposit(100, DateTime.Now, "Friend paid me back",account);
            Console.WriteLine(account.Balance);
            Console.WriteLine(services.GetAccountHistory(account));




              

                


            Console.WriteLine("-------------------------------GiftCardAccount------------------------------------------");
            GiftCardAccount giftCard = new GiftCardAccount { Number = accountNumberSeed, Owner = "Nikhil", Balance = 0 };
            accountNumberSeed++;
            services.MakeDeposit(1000, DateTime.Now, "Initial Deposit", giftCard);
            services.MakeWithdrawal(50, DateTime.Now, "buy groceries",giftCard);
            services.PerformMonthEndTransactions(giftCard);
            //// can make additional deposits:
            //giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            //Console.WriteLine(giftCard.GetAccountHistory());

            //Console.WriteLine("-------------------------------InterestEarningAccount------------------------------------------");

            //var savings = new InterestEarningAccount("savings account", 10000);
            //savings.MakeDeposit(750, DateTime.Now, "save some money");
            //savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            //savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            //savings.PerformMonthEndTransactions();
            //Console.WriteLine(savings.GetAccountHistory());

            //Console.WriteLine("-------------------------------LineOfCreditAccount------------------------------------------");

            ////var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
            ////// How much is too much to borrow?
            ////lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            ////lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            ////lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            ////lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            ////lineOfCredit.PerformMonthEndTransactions();
            ////Console.WriteLine(lineOfCredit.GetAccountHistory());
            //Abstraction
            Circle c1 = new Circle();
            double area = Circle.Area(22);
            Console.WriteLine(area);

            Square s1 = new Square(10);
            Console.WriteLine(s1.Area());
            
            //Encapsulation
            DemoEncap obj = new DemoEncap();
            obj.Name = "Govinda";
            obj.Age = 21;
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}
