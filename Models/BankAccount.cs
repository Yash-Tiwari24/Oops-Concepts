using Oops_Concepts.Opps_Concepts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oops_Concepts.Opps_Concepts
{
   public class BankAccount
    {

       

       [Key]
       [Range(3245789856,9999999999)]
        
        public uint Number { get; set; }
        public string Owner { get; set; }

        public List<Transaction> allTransactions = new List<Transaction>();

        public decimal Balance { get; set; }


      











    }
}
