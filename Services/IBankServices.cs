using Oops_Concepts.Opps_Concepts;
using Oops_Concepts.Opps_Concepts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oops_Concepts.Services
{
public    interface IBankServices
    {
       
        public void MakeDeposit(decimal amount, DateTime date, string note, BankAccount account);
        public void MakeWithdrawal(decimal amount, DateTime date, string note,BankAccount account);
        public string GetAccountHistory(BankAccount account);

        public void PerformMonthEndTransactions(BankAccount account);



    }
}
