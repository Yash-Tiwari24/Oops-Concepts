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
            // Create a new dictionary of strings, with int keys.
            Dictionary<int, string> img = new Dictionary<int, string>();

            img.Add(1, "png");
            img.Add(2, "jpg");
            img.Add(3, "jpeg");
            img.Add(4, "gif");

            Console.WriteLine("Using Dictionary");
            foreach (KeyValuePair<int, string> kvp in img)
            {
                Console.WriteLine("Image Id ={0} and Type={1}", kvp.Key, kvp.Value);
            }


            List<string> part = new List<string>();
            //the Clear method is used to remove all items from the list, and the Capacity and Count properties are displayed.
            
            part.Add("crank");
            part.Add("chain");
            part.Add("regular");
            part.Add("banana");
            part.Add("cassette");
          
            Console.WriteLine("\nCount: {0}", part.Count);

            foreach (var item in part)
            {
                Console.WriteLine(item);
            }


            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");
            Console.WriteLine("\n");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dequeuing '{0}' ",numbers.Dequeue());
            Console.WriteLine("\n");


            SortedList<string, string> openWith =new SortedList<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            foreach (var item in openWith)
            {
                Console.WriteLine("Extention {0} and Editor Name is {1}",item.Key,item.Value);

            }
            Console.WriteLine();

            Stack<string> stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");
            stack.Push("five");
           
            foreach (string number in stack)
            {
                Console.WriteLine(number);
            }



        }
    }
}
