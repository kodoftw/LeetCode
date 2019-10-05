using Xunit;

namespace _812_LargestTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.LargestTriangleArea(new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, 2 }, new[] { 2, 0 } }));
        }
    }
}
