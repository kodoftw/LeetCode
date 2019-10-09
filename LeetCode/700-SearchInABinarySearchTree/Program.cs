using BinaryTree;
using Xunit;

namespace _700_SearchInABinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 2, 1, 3 })),
                Printer.InOrder(solution.SearchBST(Builder.CreateTree(new int?[] { 4, 2, 7, 1, 3 }), 2)));
        }
    }
}
