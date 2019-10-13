using BinaryTree;
using Xunit;

namespace _654_MaximumBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 6, 3, 5, null, 2, 0, null, null, 1 })),
                Printer.InOrder(new Solution().ConstructMaximumBinaryTree(new[] { 3, 2, 1, 6, 0, 5 })));
        }
    }
}
