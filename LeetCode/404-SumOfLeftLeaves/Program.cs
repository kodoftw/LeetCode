using BinaryTree;
using Xunit;

namespace _404_SumOfLeftLeaves
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(24, solution.SumOfLeftLeaves(Builder.CreateTree(new int?[] { 3, 9, 20, null, null, 15, 7 })));
        }
    }
}
