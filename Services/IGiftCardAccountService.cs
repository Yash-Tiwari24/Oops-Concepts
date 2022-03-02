using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts.Services
{
   public interface IGiftCardAccountService
    {
        public void PerformMonthEndTransactions(decimal _monthlyDeposit);
    }
}
