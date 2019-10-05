using Xunit;

namespace _671_SecondMinimumNodeInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(5, solution.FindSecondMinimumValue(CreateTreeFromArray(new int?[] { 2, 2, 5, null, null, 5, 7 })));
            Assert.Equal(-1, solution.FindSecondMinimumValue(CreateTreeFromArray(new int?[] { 2, 2, 2 })));
        }

        private static TreeNode CreateTreeFromArray(int?[] array, int index = 0)
        {
            if (index < array.Length && array[index].HasValue)
            {
                var node = new TreeNode(array[index].Value);

                node.left = CreateTreeFromArray(array, 2 * index + 1);
                node.right = CreateTreeFromArray(array, 2 * index + 2);

                return node;
            }

            return null;
        }
    }
}
