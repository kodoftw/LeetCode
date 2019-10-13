using Xunit;

namespace _390_EliminationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(6, solution.LastRemaining(9));
        }
    }
}
