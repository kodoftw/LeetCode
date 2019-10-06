using Xunit;

namespace _13_RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.RomanToInt("III"));
            Assert.Equal(4, solution.RomanToInt("IV"));
            Assert.Equal(9, solution.RomanToInt("IX"));
            Assert.Equal(58, solution.RomanToInt("LVIII"));
            Assert.Equal(1994, solution.RomanToInt("MCMXCIV"));
        }
    }
}
