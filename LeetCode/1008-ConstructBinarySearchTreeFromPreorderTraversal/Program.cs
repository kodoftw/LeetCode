using BinaryTree;
using Xunit;

namespace _1008_ConstructBinarySearchTreeFromPreorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 8, 5, 10, 1, 7, null, 12 })),
                Printer.InOrder(new Solution().BstFromPreorder(new[] { 8, 5, 1, 7, 10, 12 })));
        }
    }
}
