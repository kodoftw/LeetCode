using Xunit;

namespace _309_BestTimeToBuyAndSellStockWithCooldown
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.MaxProfit(new[] { 1, 2, 3, 0, 2 }));
        }
    }
}
