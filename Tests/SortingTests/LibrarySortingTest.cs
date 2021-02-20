using console.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.SortingTests
{
    public class LibrarySortingTest
    {
        [Fact]
        public void TestLibrarySorting()
        {
            var librarySorting = new LibrarySorting();
            var testArray = new int[] { 5, 6, 8, 2, 1, 7 };
            var testList = new List<int>() { 5, 6, 8, 2, 1, 7 };
            librarySorting.sortArray(testArray);
            librarySorting.sortList(testList);
            for (var i = 0; i < testArray.Length - 1; i++)
            {
                Assert.True(testArray[i] <= testArray[i + 1]);
                Assert.True(testList[i] <= testList[i + 1]); 
            }
        }
        
    }
}
