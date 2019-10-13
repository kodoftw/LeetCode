using Xunit;

namespace _174_DungeonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(7, new Solution().CalculateMinimumHP(new[] { new[] { -2, -3, 3 }, new[] { -5, -10, 1 }, new[] { 10, 30, -5 } }));
        }
    }
}
