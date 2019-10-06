using BinaryTree;
using Xunit;

namespace _437_PathSumIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.PathSum(Builder.CreateTree(new int?[] { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 }), 8));
        }
    }
}
