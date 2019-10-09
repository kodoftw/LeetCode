using Xunit;

namespace _500_KeyboardRow
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { "Alaska", "Dad" }, solution.FindWords(new[] { "Hello", "Alaska", "Dad", "Peace" }));
        }
    }
}
