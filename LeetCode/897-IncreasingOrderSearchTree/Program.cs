using BinaryTree;
using Xunit;

namespace _897_IncreasingOrderSearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6, null, 7, null, 8, null, 9 })),
                Printer.InOrder(solution.IncreasingBST(Builder.CreateTree(new int?[] { 5, 3, 6, 2, 4, null, 8, 1, null, null, null, 7, 9 }))));
        }
    }
}
