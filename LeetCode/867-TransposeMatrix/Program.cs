using Xunit;

namespace _867_TransposeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                new[] { new[] { 1, 4, 7 }, new[] { 2, 5, 8 }, new[] { 3, 6, 9 } },
                solution.Transpose(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } }));

            Assert.Equal(
                new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 3, 6 } },
                solution.Transpose(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }}));
        }
    }
}
