using BinaryTree;
using Xunit;

namespace _814_BinaryTreePruning
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 1, null, 0, null, 1 })),
                Printer.InOrder(new Solution().PruneTree(Builder.CreateTree(new int?[] { 1, null, 0, 0, 1 }))));
        }
    }
}
