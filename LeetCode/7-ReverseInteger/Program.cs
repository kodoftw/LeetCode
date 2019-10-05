using Xunit;

namespace _7_ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(321, solution.Reverse(123));
            Assert.Equal(-321, solution.Reverse(-123));
            Assert.Equal(21, solution.Reverse(120));
        }
    }
}
