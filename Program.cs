using System;
using System.Collections.Generic;
using System.Linq;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Specify the data source.
            //int[] scores = { 97, 92, 81, 60 };

            //// Define the query expression.
            //IEnumerable<int> scoreQuery =
            //   from score in scores
            //    where score > 80
            //    select score;

           
            
            //IEnumerable<int> highScoresQuery =
            //from score in scores
            //  where score > 80
            //     orderby score descending
            //select score;

            //IEnumerable<string> highScoresQuery2 =
            //from score in scores
            //where score > 80
            //orderby score descending
            //select $"The score is {score}";


            //// Execute the query.
            //foreach (int i in highScoresQuery)
            //{
            //    Console.Write(i + " ");
            //}

            //int highScoreCount = (
            //from score in scores
            //where score > 80
            //select score
            //).Count();

            //Console.WriteLine(highScoreCount);


            //IEnumerable<int> highScoresQuery3 =
            //from score in scores
            //where score > 80
            //select score;

            //int scoreCount = highScoresQuery3.Count();


            // Execute the query.
            //foreach (string i in highScoresQuery2)
            //{
            //    Console.WriteLine();
            //    Console.Write(i + " ");
            //}






            //// Data source.
            //int[] scores = { 90, 71, 82, 93, 75, 82 };

            //// Query Expression.
            //IEnumerable<int> scoreQuery = //query variable
            //    from score in scores //required
            //where score > 80 // optional
            //orderby score descending // optional
            //select score; //must end with select or group

          


            //List<int> numbers = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// The query variables can also be implicitly typed by using var

            //IEnumerable<int> filteringQuery =
            //    from num in numbers
            //    where num < 3 || num > 7
            //    select num;

         
            //IEnumerable<int> orderingQuery =
            //    from num in numbers
            //    where num < 3 || num > 7
            //    orderby num ascending
            //    select num;

            //string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            //IEnumerable<IGrouping<char, string>> queryFoodGroups =
            //    from item in groupingQuery
            //    group item by item[0];


            //// Execute the query to produce the results
            //foreach (string testScore in groupingQuery)
            //{
            //    Console.WriteLine(testScore);
            //}


            //List<int> numbers1 = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //List<int> numbers2 = new() { 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 };

            //// Query #4.
            //double average = numbers1.Count();
           

            

            //// Query #5.
            //IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);
   

            //foreach (var item in concatenationQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers11 = { 2, 3, 4, 5 };
            //var squaredNumbers = numbers11.Select(x => x * x);
            //Console.WriteLine(string.Join(" ", squaredNumbers));

            List<Student> students = Student.students;

            //void QueryHighScores(int exam, int score)
            //{
            //    var highScores =
            //        from student in students
            //        where student.ExamScores[exam] > score
            //        select new
            //        {
            //            Name = student.FirstName,
            //            Score = student.ExamScores[exam]
            //        };

            //    foreach (var item in highScores)
            //    {
            //        Console.WriteLine($"{item.Name,-15}{item.Score}");
            //    }
            //}

            //QueryHighScores(2, 90);




            //// QueryMethod1 returns a query as its value.
            //IEnumerable<string> QueryMethod1(int[] ints) =>
            //    from i in ints
            //    where i > 4
            //    select i.ToString();

            //// QueryMethod2 returns a query as the value of the out parameter returnQ
            //void QueryMethod2(int[] ints, out IEnumerable<string> returnQ) =>
            //    returnQ =
            //        from i in ints
            //        where i < 4
            //        select i.ToString();

            //int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //// QueryMethod1 returns a query as the value of the method.
            //var myQuery1 = QueryMethod1(nums);

            //// Query myQuery1 is executed in the following foreach loop.
            //Console.WriteLine("Results of executing myQuery1:");

            //foreach (var s in myQuery1)
            //{
            //    Console.WriteLine(s);
            //}


            //Console.WriteLine("\nResults of executing myQuery1 directly:");

            //foreach (var s in QueryMethod1(nums))
            //{
            //    Console.WriteLine(s);
            //}

            //// QueryMethod2 returns a query as the value of its out parameter.
            //QueryMethod2(nums, out IEnumerable<string> myQuery2);

            //// Execute the returned query.
            //Console.WriteLine("\nResults of executing myQuery2:");
            //foreach (var s in myQuery2)
            //{
            //    Console.WriteLine(s);
            //}


            //myQuery1 =
            //    from item in myQuery1
            //    orderby item descending
            //    select item;

            //// Execute the modified query.
            //Console.WriteLine("\nResults of executing modified myQuery1:");
            //foreach (var s in myQuery1)
            //{
            //    Console.WriteLine(s);
            //}



            //Package.ToDictionaryEx1();
            //Package.ToLookupEx1();


            //var groupByLastNamesQuery =
            //from student in students
            //group student by student.LastName into newGroup
            //orderby newGroup.Key
            //select newGroup;

            //foreach (var nameGroup in groupByLastNamesQuery)
            //{
            //    Console.WriteLine($"Key: {nameGroup.Key}");
            //    foreach (var student in nameGroup)
            //    {
            //        Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
            //    }
            //}


            //var groupByFirstLetterQuery =
            //from student in students
            //group student by student.LastName[0];

            //foreach (var studentGroup in groupByFirstLetterQuery)
            //{
            //    Console.WriteLine($"Key: {studentGroup.Key}");
            //    Nested foreach is required to access group items.
            //    foreach (var student in studentGroup)
            //    {
            //        Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
            //    }
            //}





            //int GetPercentile(Student s)
            //{
            //    double avg = s.ExamScores.Average();
            //    return avg > 0 ? (int)avg / 10 : 0;
            //}

            //var groupByPercentileQuery =
            //    from student in students
            //    let percentile = GetPercentile(student)
            //    group new
            //    {
            //        student.FirstName,
            //        student.LastName
            //    } by percentile into percentGroup
            //    orderby percentGroup.Key
            //    select percentGroup;

            //// Nested foreach required to iterate over groups and group items.
            //foreach (var studentGroup in groupByPercentileQuery)
            //{
            //    Console.WriteLine($"Key: {studentGroup.Key * 10}");
            //    foreach (var item in studentGroup)
            //    {
            //        Console.WriteLine($"\t{item.LastName}, {item.FirstName}");
            //    }
            //}




            //var groupByHighAverageQuery =
            // from student in students
            //group new
            //{
            //  student.FirstName,
            //  student.LastName
            //} by student.ExamScores.Average() > 75 into studentGroup
            //select studentGroup;

            //foreach (var studentGroup in groupByHighAverageQuery)
            //{
            //    Console.WriteLine($"Key: {studentGroup.Key}");
            //    foreach (var student in studentGroup)
            //    {
            //        Console.WriteLine($"\t{student.FirstName} {student.LastName}");
            //    }
            //}


            //var groupByCompoundKey =
            //from student in students
            //group student by new
            //{
            //  FirstLetter = student.LastName[0],
            //     IsScoreOver85 = student.ExamScores[0] > 85
            //} into studentGroup
            //orderby studentGroup.Key.FirstLetter
            //select studentGroup;

            //foreach (var scoreGroup in groupByCompoundKey)
            //{
            //    string s = scoreGroup.Key.IsScoreOver85 == true ? "more than 85" : "less than 85";
            //    Console.WriteLine($"Name starts with {scoreGroup.Key.FirstLetter} who scored {s}");
            //    foreach (var item in scoreGroup)
            //    {
            //        Console.WriteLine($"\t{item.FirstName} {item.LastName}");
            //    }
            //}


            var nestedGroupsQuery =
            from student in students
            group student by student.Year into newGroup1
            from newGroup2 in (
            from student in newGroup1
            group student by student.LastName
            )
            group newGroup2 by newGroup1.Key;

            foreach (var outerGroup in nestedGroupsQuery)
            {
                Console.WriteLine($"DataClass.Student Level = {outerGroup.Key}");
                foreach (var innerGroup in outerGroup)
                {
                    Console.WriteLine($"\tNames that begin with: {innerGroup.Key}");
                    foreach (var innerGroupElement in innerGroup)
                    {
                        Console.WriteLine($"\t\t{innerGroupElement.LastName} {innerGroupElement.FirstName}");
                    }
                }
            }











        }
    }
}
