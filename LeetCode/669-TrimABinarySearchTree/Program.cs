using BinaryTree;
using Xunit;

namespace _669_TrimABinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 1, null, 2 })),
                Printer.InOrder(solution.TrimBST(Builder.CreateTree(new int?[] { 1, 0, 2 }), 1, 2)));

            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 3, 2, null, 1 })),
                Printer.InOrder(solution.TrimBST(Builder.CreateTree(new int?[] { 3, 0, 4, null, 2, null, null, 1 }), 1, 3)));
        }
    }
}
