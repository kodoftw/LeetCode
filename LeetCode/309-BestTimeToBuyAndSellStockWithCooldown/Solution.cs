using System;

namespace _309_BestTimeToBuyAndSellStockWithCooldown
{
    internal class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int sell = 0, prevSell = 0;
            int buy = int.MinValue;

            foreach (var price in prices)
            {
                int prevBuy = buy;
                buy = Math.Max(prevSell - price, prevBuy);

                prevSell = sell;
                sell = Math.Max(prevBuy + price, prevSell);
            }

            return sell;
        }
    }
}
