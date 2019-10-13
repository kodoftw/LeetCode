using BinaryTree;
using Xunit;

namespace _1123_LowestCommonAncestorOfDeepestLeaves
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(Printer.InOrder(Builder.CreateTree(new int?[] { 1, 2, 3 })),
                Printer.InOrder(new Solution().LcaDeepestLeaves(Builder.CreateTree(new int?[] { 1, 2, 3 }))));

            Assert.Equal(Printer.InOrder(Builder.CreateTree(new int?[] { 4 })),
                Printer.InOrder(new Solution().LcaDeepestLeaves(Builder.CreateTree(new int?[] { 1, 2, 3, 4 }))));

            Assert.Equal(Printer.InOrder(Builder.CreateTree(new int?[] { 2, 4, 5 })),
                Printer.InOrder(new Solution().LcaDeepestLeaves(Builder.CreateTree(new int?[] { 1, 2, 3, 4, 5 }))));
        }
    }
}
