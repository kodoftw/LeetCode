using Xunit;

namespace _496_NextGreaterElementI
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { -1, 3, -1 }, solution.NextGreaterElement(new[] { 4, 1, 2 }, new[] { 1, 3, 4, 2 }));
            Assert.Equal(new[] { 3, -1 }, solution.NextGreaterElement(new[] { 2, 4 }, new[] { 1, 2, 3, 4 }));
        }
    }
}
