using BinaryTree;
using Xunit;

namespace _606_ConstructStringFromBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal("1(2(4))(3)", solution.Tree2str(Builder.CreateTree(new int?[] { 1, 2, 3, 4 })));
            Assert.Equal("1(2()(4))(3)", solution.Tree2str(Builder.CreateTree(new int?[] { 1, 2, 3, null, 4 })));
        }
    }
}
