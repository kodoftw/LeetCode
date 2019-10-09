using Xunit;

namespace _762_PrimeNumberOfSetBitsInBinaryRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(4, solution.CountPrimeSetBits(6, 10));
            Assert.Equal(5, solution.CountPrimeSetBits(10, 15));
        }
    }
}
