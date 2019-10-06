using BinaryTree;
using Xunit;

namespace _783_MinimumDistanceBetweenBSTNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.MinDiffInBST(Builder.CreateTree(new int?[] { 4, 2, 6, 1, 3, null, null })));
        }
    }
}
