using System;
using System.Collections.Generic;
using Sorting;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSorter mergeSorter = new MergeSorter();
            List<int> list = new List<int>() {
                6, 5, 2,1,7,9,8
            };
            Console.WriteLine("Old list:");
            foreach(var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            var list2 = mergeSorter.merge_sort(list);
            Console.WriteLine("New List:");
            foreach(var item in list2)
            {
                Console.Write(item);
            }
            Console.WriteLine("");

        }
    }
}
