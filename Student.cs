using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    class Student
    {
        public int RollNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }

        List<Student> students = new List<Student>()
           {
               new Student{RollNo=1,FirstName="Amit",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="1st",Gender="Male" },
               new Student{RollNo=2,FirstName="Nidhi",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="2nd",Gender="Female" },
               new Student{RollNo=3,FirstName="Sarvesh",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="3rd",Gender="Male"},
               new Student{RollNo=4,FirstName="Rasika",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="2nd",Gender="Female" },
               new Student{RollNo=5,FirstName="Ravi",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="2nd",Gender="Male" },
               new Student{RollNo=6,FirstName="Amey",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="3rd",Gender="Male" },
               new Student{RollNo=7,FirstName="Prachi",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="4th",Gender="Female" },
               new Student{RollNo=8,FirstName="Manoj",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="5th",Gender="Male"},
               new Student{RollNo=9,FirstName="Govinda",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="1st",Gender="Male" },
               new Student{RollNo=10,FirstName="Nikita",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="5th",Gender="Female"},
               new Student{RollNo=11,FirstName="Ayush",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="6th",Gender="Male" },
               new Student{RollNo=12,FirstName="Rishi",LastName="Sharma",Dob=Convert.ToDateTime("22-03-2002"),Class="2nd",Gender="Male" }

           };



    }
}
