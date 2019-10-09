using Xunit;

namespace _883_ProjectionAreaOf3DShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(5, solution.ProjectionArea(new[] { new[] { 2 } }));
            Assert.Equal(17, solution.ProjectionArea(new[] { new[] { 1, 2 }, new[] { 3, 4 } }));
            Assert.Equal(8, solution.ProjectionArea(new[] { new[] { 1,0 }, new[] { 0, 2 } }));
            Assert.Equal(14, solution.ProjectionArea(new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } }));
            Assert.Equal(21, solution.ProjectionArea(new[] { new[] { 2, 2, 2 }, new[] { 2, 1, 2 }, new[] { 2, 2, 2 } }));
        }
    }
}
