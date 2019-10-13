using BinaryTree;
using Xunit;

namespace _114_FlattenBinaryTreeToLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var node = Builder.CreateTree(new int?[] { 1, 2, 5, 3, 4, null, 6 });
            solution.Flatten(node);
            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 1, null, 2, null, 3, null, 4, null, 5, null, 6 })),
                Printer.InOrder(node));
        }
    }
}
