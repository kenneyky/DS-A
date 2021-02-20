
using Sorting;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class MergeSorterTest
    {
        [Fact]
        public void TestMergeSorter()
        {
            MergeSorter mergeSorter = new MergeSorter();
            List<int> list = new List<int>() {
                6, 5, 2,1,7,9,8
            };
            Console.WriteLine("Old list:");
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            var list2 = mergeSorter.merge_sort(list);
            Console.WriteLine("New List:");
            foreach (var item in list2)
            {
                Console.Write(item);
            }
            for (var i = 0; i < list2.Count - 1; i++)
            {
                Assert.True(list2[i] <= list2[i + 1]) ;
            }
        }
    }
}
