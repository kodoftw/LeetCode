using Xunit;

namespace _292_NimGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.False(solution.CanWinNim(4));
        }
    }
}
