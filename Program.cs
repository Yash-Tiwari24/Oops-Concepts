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
            //// Specify the data source.
            //int[] scores = { 97, 92, 81, 60 };

            img.Add(1, "png");
            img.Add(2, "jpg");
            img.Add(3, "jpeg");
            img.Add(4, "gif");

            

<<<<<<<<< Temporary merge branch 1
            //List<string> part = new List<string>();
            ////the Clear method is used to remove all items from the list, and the Capacity and Count properties are displayed.
            
            //part.Add("crank");
            //part.Add("chain");
            //part.Add("regular");
            //part.Add("banana");
            //part.Add("cassette");
          
            //Console.WriteLine("\nCount: {0}", part.Count);

            //foreach (var item in part)
            //{
            //    Console.WriteLine(item);
            //}


            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");
            //Console.WriteLine();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Dequeuing '{0}' ",numbers.Dequeue());
            //Console.WriteLine();


            //SortedList<string, string> openWith =new SortedList<string, string>();
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("dib", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //foreach (var item in openWith)
            //{
            //    Console.WriteLine("Extention {0} and Editor Name is {1}",item.Key,item.Value);

            //}
            //Console.WriteLine();

            //Stack<string> stack = new Stack<string>();
            //stack.Push("one");
            //stack.Push("two");
            //stack.Push("three");
            //stack.Push("four");
            //stack.Push("five");
           
            //foreach (string number in stack)
            //{
            //    Console.WriteLine(number);
            //}
=========
            List<string> part = new List<string>();
            //the Clear method is used to remove all items from the list, and the Capacity and Count properties are displayed.
            
            part.Add("crank");
            part.Add("chain");
            part.Add("regular");
            part.Add("banana");
            part.Add("cassette");

           
            Console.WriteLine("Using List");

            foreach (var item in part)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nCount: {0}", part.Count);


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
            Console.WriteLine("Dequeuing '{0}' ", numbers.Dequeue());
            Console.WriteLine();





            SortedList<string, string> openWith = new SortedList<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Console.WriteLine("Using SortedList");
            foreach (var item in openWith)
            {
                Console.WriteLine("Extention {0} and Editor Name is {1}", item.Key, item.Value);
>>>>>>>>> Temporary merge branch 2



            // Creates and initializes a new ArrayList.
            ArrayList AL = new ArrayList();
            //AL.Add("Hello");
            //AL.Add("World");
            //AL.Add("!");
            //foreach (var item in AL)
            //{
            //    Console.WriteLine(item);
            //}


            // Create a new hash table.
            // hashtable hash = new hashtable();
            //hash.add("txt", "notepad.exe");
            //hash.add("bmp", "paint.exe");
            //hash.add("dib", "paint.exe");
            //hash.add("rtf", "wordpad.exe");
            //foreach (dictionaryentry item in hash)
            //{
            //    console.writeline("extention {0} and editor name is {1}", item.key, item.value);

            //}


            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            foreach (var item in myQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

<<<<<<<<< Temporary merge branch 1
            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("myStack World");
            myStack.Push("!");
            foreach (var item in myStack)
=========



            Stack<string> stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            stack.Push("four");
            stack.Push("five");

            Console.WriteLine("Using Stack");
            foreach (string number in stack)
>>>>>>>>> Temporary merge branch 2
            {
                Console.WriteLine(item);
            }


<<<<<<<<< Temporary merge branch 1
=========

            // Creates and initializes a new ArrayList.
            ArrayList AL = new ArrayList();
            AL.Add("Hello");
            AL.Add("World");
            AL.Add("!");

            Console.WriteLine("Using ArrayList");
            foreach (var item in AL)
            {
                Console.WriteLine(item);
            }


            // Create a new hash table.
            Hashtable hash = new Hashtable();
            hash.Add("txt", "notepad.exe");
            hash.Add("bmp", "paint.exe");
            hash.Add("dib", "paint.exe");
            hash.Add("rtf", "wordpad.exe");

            Console.WriteLine("Using ArrayList");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine("extention {0} and editor name is {1}", item.Key, item.Value);

            }


            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            foreach (var item in myQ)
            {
                Console.WriteLine(item);
            }

            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("myStack World");
            myStack.Push("!");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }





>>>>>>>>> Temporary merge branch 2
        }
    }
}
