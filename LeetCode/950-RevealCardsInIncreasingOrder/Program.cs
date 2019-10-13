using Xunit;

namespace _950_RevealCardsInIncreasingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new[] { 2, 13, 3, 11, 5, 17, 7 }, new Solution().DeckRevealedIncreasing(new[] { 17, 13, 11, 2, 3, 5, 7 }));
        }
    }
}
