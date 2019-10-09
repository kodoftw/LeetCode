using BinaryTree;
using Xunit;

namespace _872_Leaf_SimilarTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.LeafSimilar(
                Builder.CreateTree(new int?[] { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 }),
                Builder.CreateTree(new int?[] { 3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8 })));
        }
    }
}
