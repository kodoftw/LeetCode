using Xunit;

namespace _785_IsGraphBipartite
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsBipartite(new[] { new[] { 1, 3 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 0, 2 } }));
            Assert.False(solution.IsBipartite(new[] { new[] { 1, 2, 3 }, new[] { 0, 2 }, new[] { 0, 1, 3 }, new[] { 0, 2 } }));
        }
    }
}
