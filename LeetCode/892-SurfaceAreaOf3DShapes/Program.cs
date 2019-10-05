using Xunit;

namespace _892_SurfaceAreaOf3DShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(10, solution.SurfaceArea(new[] { new[] { 2 } }));
            Assert.Equal(34, solution.SurfaceArea(new[] { new[] { 1, 2 }, new[] { 3, 4 } }));
            Assert.Equal(16, solution.SurfaceArea(new[] { new[] { 1, 0 }, new[] { 0, 2 } }));
            Assert.Equal(32, solution.SurfaceArea(new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } }));
            Assert.Equal(46, solution.SurfaceArea(new[] { new[] { 2, 2, 2 }, new[] { 2, 1, 2 }, new[] { 2, 2, 2 } }));
        }
    }
}
