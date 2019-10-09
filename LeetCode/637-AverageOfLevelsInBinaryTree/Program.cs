using BinaryTree;
using Xunit;

namespace _637_AverageOfLevelsInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(new[] { 3d, 14.5d, 11d }, solution.AverageOfLevels(Builder.CreateTree(new int?[] { 3, 9, 20, 15, 7 })));
        }
    }
}
