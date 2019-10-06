using Xunit;

namespace _733_FloodFill
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[,] { { 2, 2, 2 }, { 2, 2, 0 }, { 2, 0, 1 } },
                solution.FloodFill(new[,] { { 1, 1, 1 },{ 1, 1, 0 },{ 1, 0, 1 } }, 1, 1, 2));
        }
    }
}
