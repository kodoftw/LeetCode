using BinaryTree;
using Xunit;

namespace _701_InsertIntoABinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 4, 2, 7, 1, 3, 5 })),
                Printer.InOrder(new Solution().InsertIntoBST(Builder.CreateTree(new int?[] { 4, 2, 7, 1, 3 }), 5)));
        }
    }
}
