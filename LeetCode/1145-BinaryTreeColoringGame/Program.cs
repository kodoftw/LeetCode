using BinaryTree;
using Xunit;

namespace _1145_BinaryTreeColoringGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.True(new Solution().BtreeGameWinningMove(Builder.CreateTree(new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }), 11, 3));
        }
    }
}
