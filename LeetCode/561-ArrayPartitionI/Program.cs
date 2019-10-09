using Xunit;

namespace _561_ArrayPartitionI
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(4, solution.ArrayPairSum(new[] { 1, 4, 3, 2 }));
        }
    }
}
