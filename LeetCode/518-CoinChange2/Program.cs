using Xunit;

namespace _518_CoinChange2
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(4, solution.Change(5, new[] { 1, 2, 5 }));
        }
    }
}
