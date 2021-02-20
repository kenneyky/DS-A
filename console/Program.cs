using console.Sorting;
using Sorting;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() {
            //    6, 5, 2,1,7,9,8
            //};
            //MergeSorter mergeSorter = new MergeSorter();

            //PrintList("Old list: ", list);

            //var list2 = mergeSorter.merge_sort(list);

            //Console.WriteLine("New List:");
            //PrintList("New List: ", list2);

            int[] test = new int[] { 5,3,2,6,9,9,1 };
            QuickSorter quickSorter = new QuickSorter();
            PrintArray("QuickSort Before", test);
            quickSorter.quickSort(test);
            PrintArray("QuickSort After", test);
        }

        private static void PrintArray(String text, int[] list)
        {
            Console.WriteLine(text);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
        }

        private static void PrintList(String text, List<int> list)
        {
            Console.WriteLine(text);
            foreach(var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
        }
    }
}
