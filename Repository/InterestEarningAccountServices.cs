using Oops_Concepts.Opps_Concepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts.Repository
{
 public class InterestEarningAccountServices:BankServices
    {
        public override void PerformMonthEndTransactions(BankAccount account)
        {
            if (account.Balance > 500m)
            {
                var interest = account.Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest",account);
            }
        }
    }
}
