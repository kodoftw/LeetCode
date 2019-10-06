using Xunit;

namespace _448_FindAllNumbersDisappearedInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 5, 6 }, solution.FindDisappearedNumbers(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }));
        }
    }
}
