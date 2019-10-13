using Xunit;

namespace _934_ShortestBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.ShortestBridge(new[] { new[] { 0, 1 }, new[] { 1, 0 } }));
            Assert.Equal(2, solution.ShortestBridge(new[] { new[] { 0, 1, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } }));
            Assert.Equal(1, solution.ShortestBridge(new[] { new[] { 1, 1, 1, 1, 1 }, new[] { 1, 0, 0, 0, 1 }, new[] { 1, 0, 1, 0, 1 }, new[] { 1, 0, 0, 0, 1 }, new[] { 1, 1, 1, 1, 1 } }));
        }
    }
}
