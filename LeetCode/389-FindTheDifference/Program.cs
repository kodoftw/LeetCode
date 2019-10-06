using Xunit;

namespace _389_FindTheDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal('e', solution.FindTheDifference("abcd", "abcde"));
        }
    }
}
