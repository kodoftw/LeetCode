using BinaryTree;
using Xunit;

namespace _617_MergeTwoBinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                Printer.InOrder(Builder.CreateTree(new int?[] { 3, 4, 5, 5, 4, null, 7 })),
                Printer.InOrder(solution.MergeTrees(
                    Builder.CreateTree(new int?[] { 1, 3, 2, 5 }),
                    Builder.CreateTree(new int?[] { 2, 1, 3, null, 4, null, 7 }))));
        }
    }
}
