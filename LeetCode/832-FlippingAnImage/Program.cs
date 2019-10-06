using Xunit;

namespace _832_FlippingAnImage
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                new[] { new[] { 1, 0, 0 }, new[] { 0, 1, 0 }, new[] { 1, 1, 1 } },
                solution.FlipAndInvertImage(new[] { new[] { 1, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 0, 0 } }));

            Assert.Equal(
                new[] { new[] { 1, 1, 0, 0 }, new[] { 0, 1, 1, 0 }, new[] { 1, 0, 1, 0 } },
                solution.FlipAndInvertImage(new[] { new[] { 1, 1, 0,0 }, new[] { 1, 0, 0, 1 }, new[] { 1, 0, 1, 0 } }));
        }
    }
}
