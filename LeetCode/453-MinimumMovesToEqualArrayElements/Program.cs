using Xunit;

namespace _453_MinimumMovesToEqualArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.MinMoves(new[] { 1, 2, 3 }));
        }
    }
}
