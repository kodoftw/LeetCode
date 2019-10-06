using Xunit;

namespace _27_RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.RemoveElement(new[] { 3, 2, 2, 3 }, 3));
            Assert.Equal(5, solution.RemoveElement(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));
        }
    }
}
