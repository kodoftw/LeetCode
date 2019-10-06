using Xunit;

namespace _860_LemonadeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.LemonadeChange(new[] { 5, 5, 5, 10, 20 }));
            Assert.True(solution.LemonadeChange(new[] { 5, 5, 10 }));
            Assert.False(solution.LemonadeChange(new[] { 10, 10 }));
            Assert.False(solution.LemonadeChange(new[] { 5, 5, 10, 10, 20 }));
        }
    }
}
