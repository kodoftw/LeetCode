using Xunit;

namespace _1104_PathInZigzagLabelledBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(new[] { 1, 3, 4, 14 }, new Solution().PathInZigZagTree(14));
            Assert.Equal(new[] { 1, 2, 6, 10, 26 }, new Solution().PathInZigZagTree(26));
        }
    }
}
