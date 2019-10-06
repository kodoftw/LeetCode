using Xunit;

namespace _696_CountBinarySubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(6, solution.CountBinarySubstrings("00110011"));
            Assert.Equal(4, solution.CountBinarySubstrings("10101"));
        }
    }
}
