using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts.Opps_Concepts
{
   public class GiftCardAccount:BankAccount
    {
        private decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) :base(name, initialBalance) => _monthlyDeposit = monthlyDeposit;
    }
}
