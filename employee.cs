using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    class employee
    {
        private string name;
        private int age;

        static employee() { } // Static constructor

      
    
        public static void Salary()
        {
            Console.WriteLine();
            Console.WriteLine("The Salary method");
        }
        public employee(employee emp)   // declaring Copy constructor.
        {
            name = emp.name;
            age = emp.age;
        }
        public employee(string name, int age)  
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get deatils of employee
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }
    }
}
