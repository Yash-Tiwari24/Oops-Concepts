using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
  public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void print()
        {
            Console.WriteLine(FirstName);
        }
    }

}
