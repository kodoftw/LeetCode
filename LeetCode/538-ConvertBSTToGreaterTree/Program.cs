using BinaryTree;
using Xunit;

namespace _538_ConvertBSTToGreaterTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var expected = Printer.InOrder(Builder.CreateTree(new int?[] { 18, 20, 13 }));
            var actual = Printer.InOrder(solution.ConvertBST(Builder.CreateTree(new int?[] { 5, 2, 13 })));
            Assert.Equal(expected, actual);
        }
    }
}
