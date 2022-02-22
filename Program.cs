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






            // Data source.
            int[] scores = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
            where score > 80 // optional
            orderby score descending // optional
            select score; //must end with select or group

          


            List<int> numbers = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // The query variables can also be implicitly typed by using var

            IEnumerable<int> filteringQuery =
                from num in numbers
                where num < 3 || num > 7
                select num;

         
            IEnumerable<int> orderingQuery =
                from num in numbers
                where num < 3 || num > 7
                orderby num ascending
                select num;

            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];


            // Execute the query to produce the results
            foreach (int testScore in filteringQuery)
            {
                Console.WriteLine(testScore);
            }



        }
    }
}
