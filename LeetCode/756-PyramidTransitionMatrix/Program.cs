using Xunit;

namespace _756_PyramidTransitionMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.True(new Solution().PyramidTransition("BCD", new[] { "BCG", "CDE", "GEA", "FFF" }));
            Assert.True(new Solution().PyramidTransition("AABA", new[] { "AAA", "AAB", "ABA", "ABB", "BAC" }));
        }
    }
}
