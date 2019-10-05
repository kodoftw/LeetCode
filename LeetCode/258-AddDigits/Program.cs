using Xunit;

namespace _258_AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.AddDigits(38));
        }
    }
}
