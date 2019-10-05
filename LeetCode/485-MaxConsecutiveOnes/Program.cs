using Xunit;

namespace _485_MaxConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.FindMaxConsecutiveOnes(new[] { 1, 1, 0, 1, 1, 1 }));
        }
    }
}
