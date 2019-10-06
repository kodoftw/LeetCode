using Xunit;

namespace _119_Pascal_sTriangleII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 1, 3, 3, 1 }, solution.GetRow(3));
        }
    }
}
