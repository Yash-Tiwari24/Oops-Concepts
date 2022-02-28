using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int minimumNum = a.Min();
            //int MaximumNum = a.Max();
            //Console.WriteLine("The minimum Number is {0}", minimumNum);
            //Console.WriteLine("The maximum Number is {0}", MaximumNum);
            //int Sum = a.Sum();
            //Console.WriteLine("The Sum is {0}", Sum);
            //int Count = a.Count();
            //Console.WriteLine("The Count is {0}", Count);



            //LINQ Sorting Operators (Order By, then By, Reverse)


            List<Student> Objstudent = new List<Student>()
            {
                new Student() { RoleNumberId=1, Name = "Ak", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                new Student() { RoleNumberId=2, Name = "Shalu", Gender = "Female", Subjects = new List<string> { "Computers", "Botany" } },
                new Student() { RoleNumberId=3, Name = "Shubham", Gender = "Male", Subjects = new List<string> { "Economics", "Operating System", "Java" } },
                new Student() { RoleNumberId=4, Name = "Rohit", Gender = "Male", Subjects = new List<string> { "Accounting", "Social Studies", "Chemistry" } },
                new Student() { RoleNumberId=5, Name = "Shivani", Gender = "Female", Subjects = new List<string> { "English", "Charterd" } }
            };

            //var studentname = Objstudent.OrderBy(x => x.Name);
            //var studentname1 = Objstudent.OrderByDescending(x => x.Name);
            //var studentname2 = Objstudent.OrderBy(x => x.Name).ThenBy(x => x.RoleNumberId);
            ////OrderBy is the primary sorting operator, and ThenBy is the secondary operator.

            //foreach (var student in studentname2)  
            //{
            //    Console.WriteLine("Name={0} studentid={1}", student.Name, student.RoleNumberId);

            //}
            //Console.WriteLine();




            //var studentname3 = Objstudent.OrderBy(x => x.Name).ThenByDescending(x => x.RoleNumberId);
            //foreach (var student in studentname3)
            //{
            //    Console.WriteLine("Name={0} studentid={1}", student.Name, student.RoleNumberId);

            //}


            //string[] countries = {"USA","US","UK","Russia","China","Australia","Argentina","Italy"};
            ////IEnumerable<string> result = countries.Take(3);

            //IEnumerable<string> result = countries.Where(x => x.StartsWith("R"));

            //IEnumerable<string> result1 = countries.Skip(3);
            //List<string> result2 = countries.ToList();

            //var stud = Objstudent.ToLookup(x => x.Gender);

            //foreach (var s in stud)
            //{
            //    Console.WriteLine(s.Key);

            //     foreach (var item in stud[s.Key])  
            //    {  
            //        Console.WriteLine("\t" + item.Name + "\t"  + item.RoleNumberId);
            //        foreach (var item2 in item.Subjects)
            //        {
            //            Console.WriteLine("\t"+item2);
            //        }
            //        Console.WriteLine();
            //    }  
            //}

            //ArrayList obj = new ArrayList();
            //obj.Add("USA");
            //obj.Add("Australia");
            //obj.Add("UK");
            //obj.Add("India");
            //obj.Add(1);

            //IEnumerable<string> result = obj.Cast<string>();

            //ofType() method will return the value only the specific type  
            //IEnumerable<string> result = obj.OfType<string>();

            //var student = Objstudent.ToDictionary(x => x.RoleNumberId, x => x.Name);

            //foreach (var stud in student)
            //{
            //    Console.WriteLine(stud.Key + "\t" + stud.Value);
            //}

            //  int[] NumArray = new int[] { 1, 2, 3, 4, 5 };
            //var result = NumArray.AsEnumerable();

            //int result1 = NumArray.First();
            //Console.WriteLine(result1);

            //    int[] objVal = { };
            //int result2= NumArray.FirstOrDefault();
            //int val = objVal.FirstOrDefault();
            //Console.WriteLine("Element from the List1: {0}", result2);
            //Console.WriteLine("Element from the List2: {0}", val);

            // int result1 = NumArray.Last();

            //int result2 = NumArray.LastOrDefault();
            //int val = objVal.LastOrDefault();
            //Console.WriteLine("Element from the List1: {0}", result2);
            //Console.WriteLine("Element from the List2: {0}", val);

            string[] count1 = { "India", "USA", "UK", "Australia" };
            string[] count2 = { "India", "Canada", "UK", "China" };
            
            //var result = count1.Union(count2);

            //var result1 = count1.Intersect(count2);

            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] countries = { "UK", "India", "Australia", "uk", "india", "USA" };
            //IEnumerable<string> result = countries.Distinct(StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
              
            //    Console.WriteLine(item);
            //}

            var result = count1.Except(count2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


        }
    }
}
