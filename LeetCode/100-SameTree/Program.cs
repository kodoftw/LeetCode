using BinaryTree;
using Xunit;

namespace _100_SameTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsSameTree(Builder.CreateTree(new int?[] { 1, 2, 3 }), Builder.CreateTree(new int?[] { 1, 2, 3 })));
            Assert.False(solution.IsSameTree(Builder.CreateTree(new int?[] { 1, 2 }), Builder.CreateTree(new int?[] { 1, null, 2 })));
            Assert.False(solution.IsSameTree(Builder.CreateTree(new int?[] { 1, 2, 1 }), Builder.CreateTree(new int?[] { 1, 1, 2})));
        }
    }
}
