using Xunit;

namespace _905_SortArrayByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 2, 4, 3, 1 }, solution.SortArrayByParity(new[] { 3, 1, 2, 4 }));
        }
    }
}
