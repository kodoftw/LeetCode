using Xunit;

namespace _598_RangeAdditionII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(4, solution.MaxCount(3, 3, new[,] { {2, 2},{3, 3} }));
        }
    }
}
