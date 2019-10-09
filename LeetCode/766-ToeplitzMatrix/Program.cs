using Xunit;

namespace _766_ToeplitzMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsToeplitzMatrix(
                new[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } }));

            Assert.False(solution.IsToeplitzMatrix(
                new[,] { { 1, 2 }, { 2, 2 } }));
        }
    }
}
