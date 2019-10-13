using Xunit;

namespace _4_MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(2.0d, new Solution().FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }));
            Assert.Equal(2.5d, new Solution().FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }));
        }
    }
}
