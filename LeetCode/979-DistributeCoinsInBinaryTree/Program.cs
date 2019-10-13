using BinaryTree;
using Xunit;

namespace _979_DistributeCoinsInBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Assert.Equal(2, new Solution().DistributeCoins(Builder.CreateTree(new int?[] { 3, 0, 0 })));
            Assert.Equal(3, new Solution().DistributeCoins(Builder.CreateTree(new int?[] { 0, 3, 0 })));
            Assert.Equal(2, new Solution().DistributeCoins(Builder.CreateTree(new int?[] { 1, 0, 2 })));
            Assert.Equal(4, new Solution().DistributeCoins(Builder.CreateTree(new int?[] { 1, 0, 0, null, 3 })));
        }
    }
}
