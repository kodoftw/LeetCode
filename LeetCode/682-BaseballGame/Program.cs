using Xunit;

namespace _682_BaseballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(30, solution.CalPoints(new[] { "5", "2", "C", "D", "+" }));
            Assert.Equal(27, solution.CalPoints(new[] { "5", "-2", "4", "C", "D", "9", "+", "+" }));
        }
    }
}
