using Xunit;

namespace _802_FindEventualSafeStates
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                new[] { 2, 4, 5, 6 },
                new Solution().EventualSafeNodes(new[] { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 5 }, new[] { 0 }, new[] { 5 }, new int[0], new int[0] }));
        }
    }
}
