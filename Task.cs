using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
   public class Task
    {
        
        public int Taskid { get; set; }
        public string TaskName { get; set; }
        public string AssignTo { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public string Status { get; set; }




       static List<Task> tasks = new List<Task>()
           {
               new Task(){Taskid=1,TaskName="Create Project",AssignTo="Amit",Start_Date=Convert.ToDateTime("02-02-2022"),End_Date=Convert.ToDateTime("18-02-2022"),Status="New"},
               new Task(){Taskid=2,TaskName="Init Project",AssignTo="Ayush",Start_Date=Convert.ToDateTime("22-02-2022"),End_Date=Convert.ToDateTime("28-02-2022"),Status="Inprogress"},
               new Task(){Taskid=3,TaskName="Costing Project",AssignTo="Nikhil",Start_Date=Convert.ToDateTime("02-01-2022"),End_Date=Convert.ToDateTime("10-01-2022"),Status="Completed"},
               new Task(){Taskid=4,TaskName="Testing Project",AssignTo="Gaurav",Start_Date=Convert.ToDateTime("12-01-2022"),End_Date=Convert.ToDateTime("22-01-2022"),Status="Completed"},
               new Task(){Taskid=5,TaskName="Assign Project",AssignTo="Manoj",Start_Date=Convert.ToDateTime("01-02-2022"),End_Date=Convert.ToDateTime("08-02-2022"),Status="New"},
               new Task(){Taskid=6,TaskName="Debug Project",AssignTo="Nitin",Start_Date=Convert.ToDateTime("02-02-2022"),End_Date=Convert.ToDateTime("10-02-2022"),Status="Inprogress"},
               new Task(){Taskid=7,TaskName="Compile Project",AssignTo="Deepesh",Start_Date=Convert.ToDateTime("12-02-2022"),End_Date=Convert.ToDateTime("17-02-2022"),Status="Completed"},
               new Task(){Taskid=8,TaskName="Raise Ticket",AssignTo="Rishi",Start_Date=Convert.ToDateTime("06-02-2022"),End_Date=Convert.ToDateTime("10-02-2022"),Status="Inprogress"},
               new Task(){Taskid=9,TaskName="Create EPIC",AssignTo="Parimal",Start_Date=Convert.ToDateTime("01-03-2022"),End_Date=Convert.ToDateTime("08-03-2022"),Status="New"},
               new Task(){Taskid=10,TaskName="Create Task",AssignTo="Abhishek",Start_Date=Convert.ToDateTime("12-03-2022"),End_Date=Convert.ToDateTime("25-03-2022"),Status="Inprogress"},
               new Task(){TaskName="Create User Story",AssignTo="Sahil",Start_Date=Convert.ToDateTime("01-04-2022"),End_Date=Convert.ToDateTime("15-04-2022"),Status="Inprogress"},
           };


        public static List<Task> GetProducts()
        {
            return tasks;
        }



    }
}
