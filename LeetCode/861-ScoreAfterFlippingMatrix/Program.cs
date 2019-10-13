using Xunit;

namespace _861_ScoreAfterFlippingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(39, new Solution().MatrixScore(new[] { new[] { 0, 0, 1, 1 }, new[] { 1, 0, 1, 0 }, new[] { 1, 1, 0, 0 } }));
        }
    }
}
