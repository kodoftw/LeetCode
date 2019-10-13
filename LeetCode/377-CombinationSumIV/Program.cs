using Xunit;

namespace _377_CombinationSumIV
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(7, solution.CombinationSum4(new[] { 1, 2, 3 }, 4));
        }
    }
}
