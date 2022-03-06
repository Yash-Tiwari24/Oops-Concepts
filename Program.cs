using System;
using System.Text;

namespace Oops_Concepts
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Following is the example of Layout Convention.
            // While this is example of comment.
            int a = 10;
            int b = 20;
            int c = 30;

            if ((a > b) && (a > c))
            {
                Console.WriteLine("Hello");
            }

            //Use string interpolation to concatenate short strings, as shown in the following code.
            var lastName = "Sharma";
            var firstName = "Prakash";
            string displayName = $"{lastName}, {firstName}";

           

            // Use implicit typing for local variables when the type of the variable is obvious from
            // the right side of the assignment, or when the precise type is not important.
            var var1 = "This is clearly a string.";
            var var2 = 27;

            // Don't use var when the type is not apparent from the right side of the assignment.
            // Don't assume the type is clear from a method name.
            int var3 = Convert.ToInt32(Console.ReadLine());
            var inputInt = Console.ReadLine();

            //Don't use implicit typing to determine the type of the loop variable in foreach loops.
            foreach (char ch in var1)
            {
                if (ch == 'h')
                    Console.Write("H");
                else
                    Console.Write(ch);
            }

            //Use the concise syntax when you initialize arrays on the declaration line.
            string[] vowels1 = { "a", "e", "i", "o", "u" };

            //If you use explicit instantiation, you can use var.
            var vowels2 = new string[] { "a", "e", "i", "o", "u" };


            // Call the method using the signature defined by the Func<> or Action<> delegate.
            ActionExample1("string for x");

            ActionExample2("string for x", "string for y");

            Console.WriteLine($"The value is {FuncExample1("1")}");

            Console.WriteLine($"The sum is {FuncExample2(1, 2)}");

            // Create an instance of the delegate type and call it.
            Del exampleDel2 = DelMethod;
            exampleDel2("Hey");

            // The following declaration uses the full syntax.
            Del exampleDel1 = new Del(DelMethod);
            exampleDel1("Hey");
            
            // To avoid exceptions and increase performance by skipping
            // unnecessary comparisons, use && instead of & and || instead of |
            Console.Write("Enter a dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            if ((divisor != 0) && (dividend / divisor > 0))
            {
                Console.WriteLine("Quotient: {0}", dividend / divisor);
            }
            else
            {
                Console.WriteLine("Attempted division by 0 ends up here.");
            }


            // Use one of the concise forms of object instantiation, as shown in the following declarations.
            // The second example shows syntax that is available starting in C# 9.
            var instance1 = new Student();
            Student instance2 = new();
            //Use object initializers to simplify object creation, as shown in the following example.
            var instance3 = new Student
            {
                Name = "Nikhil",
                ID = 276,
                Location = "Pune",
                Age = 23.5
            };
            //The following example sets the same properties as the preceding example but doesn't use initializers.
            var instance4 = new Student();
            instance4.Name = "Rahul";
            instance4.ID = 278;
            instance4.Location = "Nagpur";
            instance4.Age = 21.5;


        }

        // Use Func<> and Action<> instead of defining delegate types.
        public static Action<string> ActionExample1 = x => Console.WriteLine($"x is: {x}");

        public static Action<string, string> ActionExample2 = (x, y) =>
            Console.WriteLine($"x is: {x}, y is {y}");

        public static Func<string, int> FuncExample1 = x => Convert.ToInt32(x);

        public static Func<int, int, int> FuncExample2 = (x, y) => x + y;

        // If you create instances of a delegate type, use the concise syntax.
        // In a class, define the delegate type and a method that has a matching signature.
        public delegate void Del(string message);

        public static void DelMethod(string str)
        {
            Console.WriteLine("DelMethod argument: {0}", str);
        }
    }
}
