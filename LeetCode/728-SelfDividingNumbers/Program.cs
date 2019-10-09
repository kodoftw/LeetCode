using Xunit;

namespace _728_SelfDividingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 }, solution.SelfDividingNumbers(1, 22));
        }
    }
}
