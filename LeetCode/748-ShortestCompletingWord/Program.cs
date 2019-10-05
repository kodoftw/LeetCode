using Xunit;

namespace _748_ShortestCompletingWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("steps", solution.ShortestCompletingWord("1s3 PSt", new[] { "step", "steps", "stripe", "stepple" }));
            Assert.Equal("pest", solution.ShortestCompletingWord("1s3 456", new[] { "looks", "pest", "stew", "show" }));
        }
    }
}
