using Xunit;

namespace _427_ConstructQuadTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadTree = new Solution().Construct(new[] {
                new[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                new[] { 1, 1, 1, 1, 1, 1, 1, 1 },
                new[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new[] { 1, 1, 1, 1, 0, 0, 0, 0 },
                new[] { 1, 1, 1, 1, 0, 0, 0, 0 } });
            Assert.True(quadTree.topLeft.val
                    && quadTree.topLeft.isLeaf
                    && quadTree.bottomLeft.val
                    && quadTree.bottomLeft.isLeaf
                    && quadTree.bottomRight.isLeaf
                    && quadTree.topRight.topLeft.isLeaf
                    && quadTree.topRight.topRight.isLeaf
                    && quadTree.topRight.bottomLeft.isLeaf
                    && quadTree.topRight.bottomLeft.val
                    && quadTree.topRight.bottomRight.isLeaf
                    && quadTree.topRight.bottomRight.val);

            Assert.False(quadTree.isLeaf
                    || quadTree.topRight.isLeaf
                    || quadTree.bottomRight.val
                    || quadTree.topRight.topLeft.val
                    || quadTree.topRight.topRight.val);
        }
    }
}
