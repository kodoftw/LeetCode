using BinaryTree;
using Xunit;

namespace _530_MinimumAbsoluteDifferenceInBST
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(1, solution.GetMinimumDifference(Builder.CreateTree(new int?[] { 1, null, 3, 2 })));
        }
    }
}
