using Xunit;

namespace _804_UniqueMorseCodeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.UniqueMorseRepresentations(new[] { "gin", "zen", "gig", "msg" }));
        }
    }
}
