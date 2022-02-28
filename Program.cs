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

            //var result = count1.Except(count2);

            //var result2 = count1.Concat(count2);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}

            //IEnumerable<int> obj1 = Enumerable.Range(100, 10);

            //IEnumerable<int> obj2 = Enumerable.Repeat(100, 10);


            //foreach (var item in obj2)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };
            //// Determine whether any string in the array is longer than "banana".
            //string longestName =
            //    fruits.AsQueryable().Aggregate(
            //    "banana",
            //    (longest, next) => next.Length > longest.Length ? next : longest,
            //    fruit => fruit.ToUpper()
            //    );
            //Console.WriteLine(
            //    "The fruit with the longest name is {0}.",
            //    longestName);


            //Pet[] pets = { new Pet { Name="Barley", Age=10 },
            //       new Pet { Name="Boots", Age=4 },
            //       new Pet { Name="Whiskers", Age=6 } };

            //// Determine whether all pet names in the array start with 'B'.
            //bool allStartWithB =
            //    pets.AsQueryable().All(pet => pet.Name.StartsWith("B"));
            //Console.WriteLine(
            //    "{0} pet names start with 'B'.",
            //    allStartWithB ? "All" : "Not all");


            // List<Person> people = new List<Person>
            // { new Person { LastName = "Haas",
            //            Pets = new Pet[] { new Pet { Name="Barley", Age=10 },
            //                               new Pet { Name="Boots", Age=14 },
            //                               new Pet { Name="Whiskers", Age=6 }}},
            // new Person { LastName = "Fakhouri",
            //            Pets = new Pet[] { new Pet { Name = "Snowball", Age = 1}}},
            // new Person { LastName = "Antebi",
            //            Pets = new Pet[] { new Pet { Name = "Belle", Age = 8} }},
            // new Person { LastName = "Philips",
            //            Pets = new Pet[] { new Pet { Name = "Sweetie", Age = 2},
            //                               new Pet { Name = "Rover", Age = 13}} }
            // };

            // Determine which people have pets that are all older than 5.
            //IEnumerable<string> names = from person in people
            //                            where person.Pets.AsQueryable().All(pet => pet.Age > 5)
            //                            select person.LastName;

            // foreach (string name in names)
            //     Console.WriteLine(name);


            // List<int> numbers = new List<int> { 1, 2 };
            //// Determine if the list contains any elements.
            // bool hasElements = numbers.AsQueryable().Any();
            // Console.WriteLine("The list {0} empty.",hasElements ? "is not" : "is");

            // Creating a list of integer
            List<int> intSequence = new List<int> { 10, 20, 30, 40 };
            // Trying to append 5 at the end of the intSequence
            intSequence.Append(5);
            //It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", intSequence));
            // It works now because we are using a changed copy of the original sequence
            Console.WriteLine(string.Join(", ", intSequence.Append(5)));
            // Creating a new sequence explicitly
            List<int> newintSequence = intSequence.Append(5).ToList();
            // Printing the new sequence in the console
            Console.WriteLine(string.Join(", ", newintSequence));



        }
    }

    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Person
    {
        public string LastName { get; set; }
        public Pet[] Pets { get; set; }
    }
    
}
