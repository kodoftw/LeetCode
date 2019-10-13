using BinaryTree;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace _894_AllPossibleFullBinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new List<TreeNode> {
                Builder.CreateTree(new int?[] { 0, 0, 0, null, null, 0, 0, null, null, 0, 0 }),
                Builder.CreateTree(new int?[] { 0, 0, 0, null, null, 0, 0, 0, 0 }),
                Builder.CreateTree(new int?[] { 0, 0, 0, 0, 0, 0, 0 }),
                Builder.CreateTree(new int?[] { 0, 0, 0, 0, 0, null, null, null, null, 0, 0 }),
                Builder.CreateTree(new int?[] { 0, 0, 0, 0, 0, null, null, 0, 0 }) }.Select(Printer.InOrder),
                new Solution().AllPossibleFBT(7).Select(Printer.InOrder));
        }
    }
}
