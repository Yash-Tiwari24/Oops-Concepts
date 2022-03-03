﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Task> tasks = Task.GetProducts();






            ////function which will return number of task assigned to a user on particular day
            //Console.WriteLine(ParticularDateCount(Convert.ToDateTime("02-02-2022")));



            ////function which will return list of task for particular status
            //var status =ParticularStatus("New");
            //foreach (var item in test)
            //{
            //    Console.WriteLine(item.TaskName);
            //}


            ////function which will search task by its name
            //var name =TaskByName("Create Project");
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item.AssignTo);
            //}



            //function which will return task base on task id
            //var taskid = TaskById(1);
            //foreach (var item in taskid)
            //{
            //    Console.WriteLine(item.TaskName);
            //}



            var daterange = TaskByDateRange(Convert.ToDateTime("02-02-2022"), Convert.ToDateTime("28-02-2022"));

            foreach (var item in daterange)
            {
                Console.WriteLine(item.TaskName);
            }

         
           




           

        }

       //function which will return number of task assigned to a user on particular day 
        public static int ParticularDateCount(DateTime date)
        {
            var task = Task.GetProducts();

            return task.Where(task => task.Start_Date.Equals(date)).Count();
        }


        //function which will return list of task for particular status
       public static IEnumerable<Task> ParticularStatus(string status)
        {
            var task = Task.GetProducts();
            return task.Where(task => task.Status.Equals(status)).Select(task => task);
        }

        //create function which will search task by its name
        public static IEnumerable<Task> TaskByName(string name)
        {
            var task = Task.GetProducts();
            return task.Where(task => task.TaskName.Equals(name)).Select(task => task);
        }


        //function which will return task base on task id
        public static IEnumerable<Task> TaskById(int id)
        {
            var task = Task.GetProducts();
            return task.Where(task => task.Taskid.Equals(id)).Select(task => task);

        }



        //function which will return task list for particular date range
        public static IEnumerable<Task> TaskByDateRange(DateTime startdate,DateTime enddate)
        {
            var task = Task.GetProducts();

            return from t1 in task
                   where startdate <= t1.Start_Date
                   where enddate >= t1.Start_Date
                   select t1;


        }





    }
}
