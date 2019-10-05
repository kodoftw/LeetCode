using Xunit;

namespace _437_PathSumIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(3, solution.PathSum(CreateTreeFromArray(new int?[] { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 }), 8));
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
