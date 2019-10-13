using Xunit;

namespace _743_NetworkDelayTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.NetworkDelayTime(new[] { new[] { 2, 1, 1 }, new[] { 2, 3, 1 }, new[] { 3, 4, 1 } }, 4, 2));
        }
    }
}
