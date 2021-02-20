using Sorting;
using Xunit;

namespace Tests.SortingTests
{
    public class QuickSorterTest
    {
        
        [Fact]
        public void quickSorterTest()
        {
            int[] test = new int[] { 5, 3, 2, 6, 9, 9, 1 };
            QuickSorter quickSorter = new QuickSorter();
            
            quickSorter.quickSort(test);
            for (var i = 0; i < test.Length - 1; i++)
            {
                Assert.True(test[i] <= test[i + 1]);
            }
        }
    }
}
