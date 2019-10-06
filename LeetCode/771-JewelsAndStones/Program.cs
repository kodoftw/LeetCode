using Xunit;

namespace _771_JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.NumJewelsInStones("aA", "aAAbbbb"));
            Assert.Equal(0, solution.NumJewelsInStones("z", "ZZ"));
        }
    }
}
