using Xunit;

namespace _283_MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var arr = new[] { 0, 1, 0, 3, 12 };
            solution.MoveZeroes(arr);
            Assert.Equal(new[] { 1, 3, 12, 0, 0 }, arr);
        }
    }
}
