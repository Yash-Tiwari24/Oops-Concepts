using System;
using System.Collections.Generic;
using System.Linq;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Task task = new Task();
            List<Task> tasks = task.GetTasks();
            
            //function which will return number of task assigned to a user on particular day
            int count = program.ParticularDateCount(Convert.ToDateTime("02-02-2022"), tasks);
            Console.WriteLine("Particular Date Of Task Count \t" + count);

            Console.WriteLine("\t");

            //function which will return list of task for particular status
            var status = program.ParticularStatus("New", tasks);
            Console.WriteLine();
            Console.WriteLine("Particular Task Status");
            Console.WriteLine("Task id \t Task Name\t");
            foreach (var item in status)
            {
                Console.Write(item.Taskid + "\t");
                Console.Write("\t" + item.TaskName);
                Console.WriteLine();
            }

            Console.WriteLine("\t");

            Console.WriteLine("Task By Project Name ");
            //function which will search task by its name
            //var name = program.TaskByName("Create Project", tasks);
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item.AssignTo);
            //}

            Console.WriteLine("\t");

            //function which will return task base on task id
            Console.WriteLine("Task By Id ");
            var taskid = program.TaskById(1, tasks);
            foreach (var item in taskid)
            {
                Console.WriteLine(item.TaskName);
            }

            Console.WriteLine("\t");

            //function which will return task list for particular date range
            Console.WriteLine("Task By Date Range");
            var daterange = program.TaskByDateRange(Convert.ToDateTime("02-02-2022"), Convert.ToDateTime("28-02-2022"), tasks);
            foreach (var item in daterange)
            {
                Console.WriteLine(item.TaskName);
            }

            Console.WriteLine("\t");

            Console.WriteLine("Task By Only Name");
            var onlytaskname = program.TaskByOnlyName(tasks);
            foreach (var item in onlytaskname)
            {
                Console.Write(item.Taskid);
                Console.WriteLine();
            }

            Console.WriteLine("\t");

            Console.WriteLine("Total Number Of Task by Amit \t" + program.TaskByAssignNameCount("Amit", tasks));

            Console.WriteLine("\t");

            Console.WriteLine("Task By Particular Name");
            var taskbyname = program.TaskByAssignName("swati", tasks);
            foreach (var item in taskbyname)
            {
                Console.WriteLine(item.TaskName);
            }

            Console.WriteLine("\t");

         

            Console.WriteLine("\t");

            Console.WriteLine("Unique Task Name");
            var taskbyuniquename = program.TaskByUniqueName(tasks);
            foreach (var item in taskbyuniquename)
            {
                Console.WriteLine(item);
            }
           
            

        }
        //function which will return number of task assigned to a user on particular day 
        public int ParticularDateCount(DateTime date, List<Task> tasks)
        {
            return tasks.Count(task => task.Start_Date.Equals(date));
        }

        //function which will return list of task for particular status
        public IEnumerable<Task> ParticularStatus(string status, List<Task> tasks)
        {

            return tasks.Where(task => task.Status.Equals(status)).Select(task => task);
        }

        //create function which will search task by its name
        //public IEnumerable<Task> TaskByName(string name, List<Task> tasks)
        //{
        //    return tasks.Where(task => task.TaskName.Equals(name));
        //}

        //function which will return task base on task id
        public IEnumerable<Task> TaskById(int id, List<Task> tasks)
        {

            return tasks.Where(task => task.Taskid.Equals(id));
           

        }
        //function which will return task list for particular date range
        public IEnumerable<Task> TaskByDateRange(DateTime startdate, DateTime enddate, List<Task> tasks)
        {
            return tasks.Where(t => t.Start_Date >= startdate && t.Start_Date <= enddate);

        }

        public IEnumerable<Task> TaskByOnlyName(List<Task> tasks)
        {
            return tasks.Where(t => !string.IsNullOrEmpty(t.TaskName)).Select(t => t);
           
        }
        public int TaskByAssignNameCount(string assignname, List<Task> tasks)
        {
            return tasks.Count(task => task.AssignTo.Equals(assignname));
        }

        public IEnumerable<Task> TaskByAssignName(string assignname, List<Task> tasks)
        {
            return tasks.Where(t => t.AssignTo.Equals(assignname));
        }

        public IEnumerable<string> TaskByUniqueName(List<Task> tasks)
        {
            return tasks.Select(task => task.TaskName).Distinct();
        }


    }

}
