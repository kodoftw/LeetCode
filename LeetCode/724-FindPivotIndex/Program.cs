using Xunit;

namespace _724_FindPivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.PivotIndex(new[] { 1, 7, 3, 6, 5, 6 }));
            Assert.Equal(-1, solution.PivotIndex(new[] { 1, 2, 3 }));
        }
    }
}
