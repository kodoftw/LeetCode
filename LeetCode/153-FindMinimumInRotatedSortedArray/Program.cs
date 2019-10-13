using Xunit;

namespace _153_FindMinimumInRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.FindMin(new[] { 3, 4, 5, 1, 2 }));
            Assert.Equal(0, solution.FindMin(new[] { 4, 5, 6, 7, 0, 1, 2 }));
        }
    }
}
