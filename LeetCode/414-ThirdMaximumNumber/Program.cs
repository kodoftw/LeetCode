using Xunit;

namespace _414_ThirdMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.ThirdMax(new[] { 1, 2, 3 }));
            Assert.Equal(2, solution.ThirdMax(new[] { 1, 2 }));
            Assert.Equal(1, solution.ThirdMax(new[] { 2, 2, 3, 1 }));
        }
    }
}
