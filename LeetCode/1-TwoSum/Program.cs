using Xunit;

namespace _1_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 0, 1 }, solution.TwoSum(new[] { 2, 7, 11, 15 }, 9));
        }
    }
}
