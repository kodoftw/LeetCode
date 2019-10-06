using Xunit;

namespace _709_ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("hello", solution.ToLowerCase("Hello"));
            Assert.Equal("here", solution.ToLowerCase("here"));
            Assert.Equal("lovely", solution.ToLowerCase("LOVELY"));
        }
    }
}
