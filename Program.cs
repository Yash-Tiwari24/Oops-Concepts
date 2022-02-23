using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

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

            // List<Student> students = Student.students;

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


            //var nestedGroupsQuery =
            //from student in students
            //group student by student.Year into newGroup1
            //from newGroup2 in (
            //from student in newGroup1
            //group student by student.LastName
            //)
            //group newGroup2 by newGroup1.Key;

            //foreach (var outerGroup in nestedGroupsQuery)
            //{
            //    Console.WriteLine($"DataClass.Student Level = {outerGroup.Key}");
            //    foreach (var innerGroup in outerGroup)
            //    {
            //        Console.WriteLine($"\tNames that begin with: {innerGroup.Key}");
            //        foreach (var innerGroupElement in innerGroup)
            //        {
            //            Console.WriteLine($"\t\t{innerGroupElement.LastName} {innerGroupElement.FirstName}");
            //        }
            //    }
            //}



            //var queryGroupMax =
            //from student in students
            //group student by student.Year into studentGroup
            //select new
            //{
            //Level = studentGroup.Key,
            //HighestScore = (
            //from student2 in studentGroup
            //select student2.ExamScores.Average()
            //).Max()
            //};

            //int count = queryGroupMax.Count();
            //Console.WriteLine($"Number of groups = {count}");

            //foreach (var item in queryGroupMax)
            //{
            //    Console.WriteLine($"  {item.Level} Highest Score={item.HighestScore}");
            //}





            //var queryGroupMax1 =
            // students
            //.GroupBy(student => student.Year)
            //.Select(studentGroup => new
            //{
            //Level = studentGroup.Key,
            //HighestScore = studentGroup.Select(student2 => student2.ExamScores.Average()).Max()
            //});

            //int count1 = queryGroupMax1.Count();
            //Console.WriteLine($"Number of groups = {count1}");

            //foreach (var item in queryGroupMax1)
            //{
            //    Console.WriteLine($"  {item.Level} Highest Score={item.HighestScore}");
            //}








            //void FilterByYearType(bool oddYear)
            //{
            //    IEnumerable<Student> studentQuery;
            //    if (oddYear)
            //    {
            //        studentQuery =
            //            from student in students
            //            where student.Year == GradeLevel.FirstYear || student.Year == GradeLevel.ThirdYear
            //            select student;
            //    }
            //    else
            //    {
            //        studentQuery =
            //            from student in students
            //            where student.Year == GradeLevel.SecondYear || student.Year == GradeLevel.FourthYear
            //            select student;
            //    }

            //    string descr = oddYear ? "odd" : "even";
            //    Console.WriteLine($"The following students are at an {descr} year level:");
            //    foreach (Student name in studentQuery)
            //    {
            //        Console.WriteLine($"{name.LastName}: {name.ID}");
            //    }
            //}

            //FilterByYearType(true);



            //FilterByYearType(false);



            //Example - Simple key join

            //Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            //Person terry = new("Terry", "Adams");
            //Person charlotte = new("Charlotte", "Weiss");
            //Person arlene = new("Arlene", "Huff");
            //Person rui = new("Rui", "Raposo");

            //List<Person> people = new() { magnus, terry, charlotte, arlene, rui };

            //List<Pet> pets = new()
            //{
            //    new(Name: "Barley", Owner: terry),
            //    new("Boots", terry),
            //    new("Whiskers", charlotte),
            //    new("Blue Moon", rui),
            //    new("Daisy", magnus),
            //};

            //var query =
            //    from person in people
            //    join pet in pets on person equals pet.Owner
            //    select new
            //    {
            //        OwnerName = person.FirstName,
            //        PetName = pet.Name
            //    };

            //foreach (var ownerAndPet in query)
            //{
            //    Console.WriteLine($"\"{ownerAndPet.PetName}\" is owned by {ownerAndPet.OwnerName}");
            //}





            ////Example - Composite key join

            //List<Employee> employees = new()
            //{
            //    new(FirstName: "Terry", LastName: "Adams", EmployeeID: 522459),
            //    new("Charlotte", "Weiss", 204467),
            //    new("Magnus", "Hedland", 866200),
            //    new("Vernette", "Price", 437139)
            //};

            //List<Student> students = new()
            //{
            //    new(FirstName: "Vernette", LastName: "Price", StudentID: 9562),
            //    new("Terry", "Earls", 9870),
            //    new("Terry", "Adams", 9913)
            //};

            //// Join the two data sources based on a composite key consisting of first and last name,
            //// to determine which employees are also students.
            //var query =
            //    from employee in employees
            //    join student in students on new
            //    {
            //        employee.FirstName,
            //        employee.LastName
            //    } equals new
            //    {
            //        student.FirstName,
            //        student.LastName
            //    }
            //    select employee.FirstName + " " + employee.LastName;

            //Console.WriteLine("The following people are both employees and students:");
            //foreach (string name in query)
            //{
            //    Console.WriteLine(name);
            //}




            ////Example - Multiple join
            //Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            //Person terry = new("Terry", "Adams");
            //Person charlotte = new("Charlotte", "Weiss");
            //Person arlene = new("Arlene", "Huff");
            //Person rui = new("Rui", "Raposo");
            //Person phyllis = new("Phyllis", "Harris");

            //List<Person> people = new() { magnus, terry, charlotte, arlene, rui, phyllis };

            //List<Cat> cats = new()
            //{
            //    new(Name: "Barley", Owner: terry),
            //    new("Boots", terry),
            //    new("Whiskers", charlotte),
            //    new("Blue Moon", rui),
            //    new("Daisy", magnus),
            //};

            //List<Dog> dogs = new()
            //{
            //    new(Name: "Four Wheel Drive", Owner: phyllis),
            //    new("Duke", magnus),
            //    new("Denim", terry),
            //    new("Wiley", charlotte),
            //    new("Snoopy", rui),
            //    new("Snickers", arlene),
            //};


            //var query =
            //    from person in people
            //    join cat in cats on person equals cat.Owner
            //    join dog in dogs on new
            //    {
            //        Owner = person,
            //        Letter = cat.Name.Substring(0, 1)
            //    } equals new
            //    {
            //        dog.Owner,
            //        Letter = dog.Name.Substring(0, 1)
            //    }
            //    select new
            //    {
            //        CatName = cat.Name,
            //        DogName = dog.Name
            //    };

            //foreach (var obj in query)
            //{
            //    Console.WriteLine(
            //        $"The cat \"{obj.CatName}\" shares a house, and the first letter of their name, with \"{obj.DogName}\"."
            //    );
            //}




            ////Example - Inner join by using grouped join
            //Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            //Person terry = new("Terry", "Adams");
            //Person charlotte = new("Charlotte", "Weiss");
            //Person arlene = new("Arlene", "Huff");

            //List<Person> people = new() { magnus, terry, charlotte, arlene };

            //List<Pet> pets = new()
            //{
            //    new(Name: "Barley", Owner: terry),
            //    new("Boots", terry),
            //    new("Whiskers", charlotte),
            //    new("Blue Moon", terry),
            //    new("Daisy", magnus),
            //};

            //var query1 =
            //    from person in people
            //    join pet in pets on person equals pet.Owner into gj
            //    from subpet in gj
            //    select new
            //    {
            //        OwnerName = person.FirstName,
            //        PetName = subpet.Name
            //    };

            //Console.WriteLine("Inner join using GroupJoin():");
            //foreach (var v in query1)
            //{
            //    Console.WriteLine($"{v.OwnerName} - {v.PetName}");
            //}

            //var query2 =
            //    from person in people
            //    join pet in pets on person equals pet.Owner
            //    select new
            //    {
            //        OwnerName = person.FirstName,
            //        PetName = pet.Name
            //    };

            //Console.WriteLine();
            //Console.WriteLine("The equivalent operation using Join():");
            //foreach (var v in query2)
            //{
            //    Console.WriteLine($"{v.OwnerName} - {v.PetName}");
            //}






            //Example - Group join

            //Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            //Person terry = new("Terry", "Adams");
            //Person charlotte = new("Charlotte", "Weiss");
            //Person arlene = new("Arlene", "Huff");

            //List<Person> people = new() { magnus, terry, charlotte, arlene };

            //List<Pet> pets = new()
            //{
            //    new(Name: "Barley", Owner: terry),
            //    new("Boots", terry),
            //    new("Whiskers", charlotte),
            //    new("Blue Moon", terry),
            //    new("Daisy", magnus),
            //};


            //var query =
            //    from person in people
            //    join pet in pets on person equals pet.Owner into gj
            //    select new
            //    {
            //        OwnerName = person.FirstName,
            //        Pets = gj
            //    };

            //foreach (var v in query)
            //{
            //    Output the owner's name.
            //    Console.WriteLine($"{v.OwnerName}:");

            //    Output each of the owner's pet's names.
            //    foreach (var pet in v.Pets)
            //    {
            //        Console.WriteLine($"  {pet.Name}");
            //    }
            //}




            //// using System.Xml.Linq;

            //Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            //Person terry = new("Terry", "Adams");
            //Person charlotte = new("Charlotte", "Weiss");
            //Person arlene = new("Arlene", "Huff");

            //List<Person> people = new() { magnus, terry, charlotte, arlene };

            //List<Pet> pets = new()
            //{
            //    new(Name: "Barley", Owner: terry),
            //    new("Boots", terry),
            //    new("Whiskers", charlotte),
            //    new("Blue Moon", terry),
            //    new("Daisy", magnus),
            //};

            //XElement ownersAndPets = new("PetOwners",
            //    from person in people
            //    join pet in pets on person equals pet.Owner into gj
            //    select new XElement("Person",
            //        new XAttribute("FirstName", person.FirstName),
            //        new XAttribute("LastName", person.LastName),
            //        from subpet in gj
            //        select new XElement("Pet", subpet.Name)
            //    )
            //);

            //Console.WriteLine(ownersAndPets);


            ////Example Perform left outer joins

            //Person magnus = new(FirstName: "Magnus", LastName: "Hedlund");
            //Person terry = new("Terry", "Adams");
            //Person charlotte = new("Charlotte", "Weiss");
            //Person arlene = new("Arlene", "Huff");

            //List<Person> people = new() { magnus, terry, charlotte, arlene };

            //List<Pet> pets = new()
            //{
            //    new(Name: "Barley", Owner: terry),
            //    new("Boots", terry),
            //    new("Whiskers", charlotte),
            //    new("Blue Moon", terry),
            //    new("Daisy", magnus),
            //};

            //var query =
            //    from person in people
            //    join pet in pets on person equals pet.Owner into gj
            //    from subpet in gj.DefaultIfEmpty()
            //    select new
            //    {
            //        person.FirstName,
            //        PetName = subpet?.Name ?? string.Empty
            //    };

            //foreach (var v in query)
            //{
            //    Console.WriteLine($"{v.FirstName + ":",-15}{v.PetName}");
            //}


            //// Order the results of a join clause
            //List<Category> categories = new()
            //{
            //    new(Name: "Beverages", ID: 001),
            //    new("Condiments", 002),
            //    new("Vegetables", 003),
            //    new("Grains", 004),
            //    new("Fruit", 005)
            //};

            //List<Product> products = new()
            //{
            //    new(Name: "Cola", CategoryID: 001),
            //    new("Tea", 001),
            //    new("Mustard", 002),
            //    new("Pickles", 002),
            //    new("Carrots", 003),
            //    new("Bok Choy", 003),
            //    new("Peaches", 005),
            //    new("Melons", 005),
            //};

            //var groupJoinQuery2 =
            //    from category in categories
            //    join prod in products on category.ID equals prod.CategoryID into prodGroup
            //    orderby category.Name
            //    select new
            //    {
            //        Category = category.Name,
            //        Products =
            //            from prod2 in prodGroup
            //            orderby prod2.Name
            //            select prod2
            //    };

            //foreach (var productGroup in groupJoinQuery2)
            //{
            //    Console.WriteLine(productGroup.Category);
            //    foreach (var prodItem in productGroup.Products)
            //    {
            //        Console.WriteLine($"  {prodItem.Name,-10} {prodItem.CategoryID}");
            //    }
            //}


            ////Cross-join
            List<Category> categories = new()
            {
                new(Name: "Beverages", ID: 001),
                new("Condiments", 002),
                new("Vegetables", 003)
            };

            List<Product> products = new()
            {
                new(Name: "Tea", CategoryID: 001),
                new("Mustard", 002),
                new("Pickles", 002),
                new("Carrots", 003),
                new("Bok Choy", 003),
                new("Peaches", 005),
                new("Melons", 005),
                new("Ice Cream", 007),
                new("Mackerel", 012)
            };

            //var crossJoinQuery =
            //    from c in categories
            //    from p in products
            //    select new
            //    {
            //        c.ID,
            //        p.Name
            //    };

            //Console.WriteLine("Cross Join Query:");
            //foreach (var v in crossJoinQuery)
            //{
            //    Console.WriteLine($"{v.ID,-5}{v.Name}");
            //}


            //Non-equijoin  
            var nonEquijoinQuery =
            from p in products
            let catIds =
            from c in categories
            select c.ID
            where catIds.Contains(p.CategoryID) == true
            select new
            {
            Product = p.Name,
            p.CategoryID
            };

            Console.WriteLine("Non-equijoin query:");
            foreach (var v in nonEquijoinQuery)
            {
                Console.WriteLine($"{v.CategoryID,-5}{v.Product}");
            }

            

        }
    }
}
