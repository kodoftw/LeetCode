using BinaryTree;
using Xunit;

namespace _653_TwoSumIV_InputIsBST
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.FindTarget(Builder.CreateTree(new int?[] { 5, 3, 6, 2, 4, null, 7 }), 9));
            Assert.False(solution.FindTarget(Builder.CreateTree(new int?[] { 5, 3, 6, 2, 4, null, 7 }), 28));
        }
    }
}
