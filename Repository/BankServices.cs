using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oops_Concepts.Opps_Concepts;
using Oops_Concepts.Opps_Concepts.Models;
using Oops_Concepts.Services;

namespace Oops_Concepts.Repository
{
  public class BankServices:IBankServices
    {
        public BankServices()
        {

        }

       
        public void MakeDeposit(decimal amount, DateTime date, string note,BankAccount account)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");

            }
            List<Transaction> alltransactions = account.allTransactions;
            var deposit = new Transaction { Amount = amount, Date = date, Notes = note };
            account.Balance = account.Balance + amount;
            alltransactions.Add(deposit);

        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note,BankAccount account)
        {
            
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (account.Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            List<Transaction> alltransactions = account.allTransactions;

            var withdrawal = new Transaction { Amount = -amount, Date = date, Notes = note };
            account.Balance = account.Balance - amount;
            alltransactions.Add(withdrawal);
        }

        //Creation Of Report
        public string GetAccountHistory(BankAccount account)
        {
            List<Transaction> alltransactions = account.allTransactions;

            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in alltransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }



        public virtual void PerformMonthEndTransactions(BankAccount account) 
        {
            Console.WriteLine("Bank Account PerformMonthEndTransactions");
        }



    }
}
