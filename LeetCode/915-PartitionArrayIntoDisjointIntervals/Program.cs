using Xunit;

namespace _915_PartitionArrayIntoDisjointIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.PartitionDisjoint(new[] { 5, 0, 3, 8, 6 }));
            Assert.Equal(4, solution.PartitionDisjoint(new[] { 1, 1, 1, 0, 6, 12 }));
        }
    }
}
