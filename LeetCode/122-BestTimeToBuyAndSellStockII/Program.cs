using Xunit;

namespace _122_BestTimeToBuyAndSellStockII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(7, solution.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));
            Assert.Equal(4, solution.MaxProfit(new[] { 1, 2, 3, 4, 5 }));
            Assert.Equal(0, solution.MaxProfit(new[] { 7, 6, 4, 3, 1 }));

        }
    }
}
