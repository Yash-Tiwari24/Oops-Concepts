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

        }
    }
}
