using Xunit;

namespace _868_BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.BinaryGap(22));
            Assert.Equal(2, solution.BinaryGap(5));
            Assert.Equal(1, solution.BinaryGap(6));
            Assert.Equal(0, solution.BinaryGap(8));
        }
    }
}
