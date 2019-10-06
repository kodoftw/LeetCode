using Xunit;

namespace _371_SumOfTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.GetSum(1, 2));
            Assert.Equal(1, solution.GetSum(-2, 3));
        }
    }
}
