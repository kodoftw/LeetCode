using BinaryTree;
using Xunit;

namespace _951_FlipEquivalentBinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.True(new Solution().FlipEquiv(
                Builder.CreateTree(new int?[] { 1, 2, 3, 4, 5, 6, null, null, null, 7, 8 }),
                Builder.CreateTree(new int?[] { 1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7 })));
        }
    }
}
