using Xunit;

namespace _912_SortAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new[] { 1, 2, 3, 5 }, new Solution().SortArray(new[] { 5, 2, 3, 1 }));
            Assert.Equal(new[] { 0, 0, 1, 1, 2, 5 }, new Solution().SortArray(new[] { 5, 1, 1, 2, 0, 0 }));
        }
    }
}
