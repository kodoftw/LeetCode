using Xunit;

namespace _797_AllPathsFromSourceToTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new[] { new[] { 0, 1, 3 }, new[] { 0, 2, 3 } }, new Solution().AllPathsSourceTarget(new[] { new[] { 1, 2 }, new[] { 3 }, new[] { 3 }, new int[0] }));
        }
    }
}
