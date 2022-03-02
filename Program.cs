﻿using System;
using System.IO;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 98, b = 0;
            double result;

            //Exception Handling
            try
            {
               
                result = StaticMethods.SafeDiv(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero.");
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("Done with execution");

            }

            Console.WriteLine("\t");


            try
            {
                throw new NotFoundException("File Not Found");
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("\t");

            try
            {
                using (var sw = new StreamWriter("C/ffffff/test.txt"))
                {
                    sw.WriteLine("Hello");
                }
            }

            // Put the more specific exceptions first.
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Put the least specific exception last.
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\t");

            int[] intarray = { 1, 2, 3, 4, 5, 6, 7 };
            try
            {
                StaticMethods.GetInt(intarray, -5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\t");

            //Unhandled Exception with try-finally
            int i = 123;
            string s = "Some string";
            object obj = s;

            try
            {
                // Invalid conversion; obj contains a string, not a numeric type.
                
               i = (int)obj;

                // The following statement is not run.
                Console.WriteLine("WriteLine at the end of the try block.");
            }
            finally
            {
                // To run the program in Visual Studio, type CTRL+F5. Then
                // click Cancel in the error dialog.
                Console.WriteLine("\nExecution of the finally block after an unhandled\n" +
                    "error depends on how the exception unwind operation is triggered.");
                Console.WriteLine("i = {0}", i);
               }

            }



    }
}
