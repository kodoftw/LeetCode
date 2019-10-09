using Xunit;

namespace _463_IslandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(16, solution.IslandPerimeter(
                new[,] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } }));
        }
    }
}
