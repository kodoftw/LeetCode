using Xunit;

namespace _26_RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.RemoveDuplicates(new[] { 1, 1, 2 }));
            Assert.Equal(5, solution.RemoveDuplicates(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));
        }
    }
}
