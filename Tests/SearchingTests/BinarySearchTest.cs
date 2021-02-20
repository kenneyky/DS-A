using console.Searching;
using Xunit;

namespace Tests.SearchingTests
{
    public class BinarySearchTest
    {
        [Fact]
        public void TestBinarySearch()
        {
            var A = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            BinarySearch binarySearch = new BinarySearch();
            Assert.True(binarySearch.Iterative(A, 5));
            Assert.False(binarySearch.Iterative(A, 10));

            Assert.True(binarySearch.Recursive(A, 5, 0, A.Length - 1));
            Assert.False(binarySearch.Recursive(A, 10, 0, A.Length - 1));
        }
    }
}
