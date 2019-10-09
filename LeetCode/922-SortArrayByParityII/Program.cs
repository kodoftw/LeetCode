using Xunit;

namespace _922_SortArrayByParityII
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 4, 5, 2, 7 }, solution.SortArrayByParityII(new[] { 4, 2, 5, 7 }));
        }
    }
}
