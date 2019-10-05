using Xunit;

namespace _191_NumberOf1Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.HammingWeight(11u));
            Assert.Equal(1, solution.HammingWeight(128u));
            Assert.Equal(31, solution.HammingWeight(4294967293u));
        }
    }
}
