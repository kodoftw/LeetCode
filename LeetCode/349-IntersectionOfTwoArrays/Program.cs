using Xunit;

namespace _349_IntersectionOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 2 }, solution.Intersection(new[] { 1, 2, 2, 1 }, new[] { 2, 2 }));
            Assert.Equal(new[] { 9,4 }, solution.Intersection(new[] { 4,9,5 }, new[] { 9, 4, 9, 8, 4 }));
        }
    }
}
