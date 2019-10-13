using BinaryTree;
using Xunit;

namespace _865_SmallestSubtreeWithAllTheDeepestNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(Printer.InOrder(Builder.CreateTree(new int?[] { 2, 7, 4 })),
                 Printer.InOrder(new Solution().SubtreeWithAllDeepest(Builder.CreateTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 }))));
        }
    }
}
