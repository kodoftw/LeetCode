using BinaryTree;
using Xunit;

namespace _101_SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsSymmetric(Builder.CreateTree(new int?[] { 1, 2, 2, 3, 4, 4, 3 })));
        }
    }
}
