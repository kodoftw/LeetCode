using Xunit;

namespace _75_SortColors
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var arr = new[] { 2, 0, 2, 1, 1, 0 };
            solution.SortColors(arr);
            Assert.Equal(new[] { 0, 0, 1, 1, 2, 2 }, arr);
        }
    }
}
