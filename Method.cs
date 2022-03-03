﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
   public class Method
    {
        public static List<int> GetSmallests(List<int> list, int count)
        {

            if (list.Count < count || count <= 0)
            {
                throw new IndexOutOfRangeException($"Index must be between 0 to {list.Count}");
            }
            var buffer = list;

            var smallest = new List<int>();
            while (smallest.Count() < count)
            {
                int min = GetSmallest(buffer);
                smallest.Add(min);
                buffer.Remove(min);
            }
            return smallest;
        }

        public static int GetSmallest(List<int> list)
        {
            int min = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }

        public static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + msg);
        }

    }
}
