using Xunit;

namespace _169_MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.MajorityElement(new int[] { 3, 2, 3 }));
            Assert.Equal(2, solution.MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }
    }
}
