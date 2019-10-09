using Xunit;

namespace _852_PeakIndexInAMountainArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.PeakIndexInMountainArray(new[] { 0, 1, 0 }));
            Assert.Equal(1, solution.PeakIndexInMountainArray(new[] { 0, 2, 1, 0 }));
        }
    }
}
