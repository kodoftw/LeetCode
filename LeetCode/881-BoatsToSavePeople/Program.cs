using Xunit;

namespace _881_BoatsToSavePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.NumRescueBoats(new[] { 1, 2 }, 3));
            Assert.Equal(3, solution.NumRescueBoats(new[] { 3, 2, 2, 1 }, 3));
            Assert.Equal(4, solution.NumRescueBoats(new[] { 3, 5, 3, 4 }, 5));
        }
    }
}
