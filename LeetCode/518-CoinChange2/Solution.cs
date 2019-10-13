namespace _518_CoinChange2
{
    internal class Solution
    {
        public int Change(int amount, int[] coins)
        {
            var combinations = new int[amount + 1];
            combinations[0] = 1;

            foreach (var coin in coins)
            {
                for (int i = 1; i <= amount; i++)
                {
                    if (i < coin)
                        continue;

                    combinations[i] += combinations[i - coin];
                }
            }

            return combinations[amount];
        }
    }
}
