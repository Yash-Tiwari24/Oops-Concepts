using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
   public static class Extentions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string[] SplitString(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries);
        }

        public static char[] ToCharArray(this string str)
        {
            var c = new List<char>();
            foreach (char item in str)
            {
                c.Add(item);
            }
            return c.ToArray();

        }

        public static void print(this Student student)
        {
            Console.WriteLine(student.LastName);
        }

    }
}
