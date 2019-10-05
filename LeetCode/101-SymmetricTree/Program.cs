using Xunit;

namespace _101_SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.True(solution.IsSymmetric(CreateTreeFromArray(new int?[] { 1, 2, 2, 3, 4, 4, 3 })));
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
