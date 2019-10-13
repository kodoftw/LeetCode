using Xunit;

namespace _127_WordLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(5, solution.LadderLength("hit", "cog", new[] { "hot", "dot", "dog", "lot", "log", "cog" }));
            Assert.Equal(0, solution.LadderLength("hit", "cog", new[] { "hot", "dot", "dog", "lot", "log" }));
        }
    }
}
