using Xunit;

namespace _821_ShortestDistanceToACharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 }, solution.ShortestToChar("loveleetcode", 'e'));
        }
    }
}
