using System;
using System.Collections;
using System.Collections.Generic;

namespace Oops_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create a new dictionary of strings, with int keys.
            //Dictionary<int, string> img = new Dictionary<int, string>();

            //img.Add(1, "png");
            //img.Add(2, "jpg");
            //img.Add(3, "jpeg");
            //img.Add(4, "gif");

            //foreach (KeyValuePair<int, string> kvp in img)
            //{
            //    Console.WriteLine("Image Id ={0} and Type={1}", kvp.Key, kvp.Value);
            //}


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

            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("myStack World");
            myStack.Push("!");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }


        }
    }
}
