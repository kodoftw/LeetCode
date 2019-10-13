using Xunit;

namespace _807_MaxIncreaseToKeepCitySkyline
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(35, new Solution().MaxIncreaseKeepingSkyline(new [] { new[] { 3, 0, 8, 4 }, new[] { 2, 4, 5, 7 }, new[] { 9, 2, 6, 3 }, new[] { 0, 3, 1, 0 } }));
        }
    }
}
