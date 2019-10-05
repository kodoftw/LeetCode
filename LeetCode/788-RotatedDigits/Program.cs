using Xunit;

namespace _788_RotatedDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(4, solution.RotatedDigits(10));
        }
    }
}
