using Xunit;

namespace _461_HammingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.HammingDistance(1, 4));
        }
    }
}
