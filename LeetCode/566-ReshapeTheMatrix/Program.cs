using Xunit;

namespace _566_ReshapeTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                new[,] { { 1, 2, 3, 4 } },
                solution.MatrixReshape(new[,] { { 1, 2 }, { 3, 4 } }, 1, 4));

            Assert.Equal(
                new[,] { { 1, 2, }, { 3, 4 } },
                solution.MatrixReshape(new[,] { { 1, 2 }, { 3, 4 } }, 2, 4));
        }
    }
}
