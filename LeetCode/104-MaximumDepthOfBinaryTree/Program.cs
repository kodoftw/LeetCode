using BinaryTree;
using Xunit;

namespace _104_MaximumDepthOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.MaxDepth(Builder.CreateTree(new int?[] { 3, 9, 20, null, null, 15, 7 })));
        }
    }
}
