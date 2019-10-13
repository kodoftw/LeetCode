using BinaryTree;
using Xunit;

namespace _1038_BinarySearchTreeToGreaterSumTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 30, 36, 21, 36, 35, 26, 15, null, null, null, 33, null, null, null, 8 })),
                Printer.InOrder(new Solution().BstToGst(Builder.CreateTree(new int?[] { 4, 1, 6, 0, 2, 5, 7, null, null, null, 3, null, null, null, 8 }))));
        }
    }
}
