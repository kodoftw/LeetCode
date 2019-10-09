using BinaryTree;
using Xunit;

namespace _226_InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 4, 7, 2, 9, 6, 3, 1 })),
                Printer.InOrder(solution.InvertTree(Builder.CreateTree(new int?[] { 4, 2, 7, 1, 3, 6, 9 }))));
        }
    }
}
