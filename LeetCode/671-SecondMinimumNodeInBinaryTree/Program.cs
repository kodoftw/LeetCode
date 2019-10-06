using BinaryTree;
using Xunit;

namespace _671_SecondMinimumNodeInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(5, solution.FindSecondMinimumValue(Builder.CreateTree(new int?[] { 2, 2, 5, null, null, 5, 7 })));
            Assert.Equal(-1, solution.FindSecondMinimumValue(Builder.CreateTree(new int?[] { 2, 2, 2 })));
        }
    }
}
