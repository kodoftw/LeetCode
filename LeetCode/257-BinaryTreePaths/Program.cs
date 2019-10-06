using BinaryTree;
using Xunit;

namespace _257_BinaryTreePaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { "1->2->5", "1->3" }, solution.BinaryTreePaths(Builder.CreateTree(new int?[] { 1, 2, 3, null, 5 })));
        }
    }
}
