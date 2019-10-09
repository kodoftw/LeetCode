using Xunit;

namespace _476_NumberComplement
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(2, solution.FindComplement(5));
            Assert.Equal(0, solution.FindComplement(1));
        }
    }
}
