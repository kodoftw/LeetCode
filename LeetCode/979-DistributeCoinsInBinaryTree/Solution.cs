using BinaryTree;
using System;

namespace _979_DistributeCoinsInBinaryTree
{
    internal class Solution
    {
        private int Moves = 0;

        public int DistributeCoins(TreeNode root)
        {
            DistributeCoinsWithBalance(root);

            return Moves;
        }

        private int DistributeCoinsWithBalance(TreeNode node)
        {
            if (node == null)
                return 0;

            int left = DistributeCoinsWithBalance(node.left);
            int right = DistributeCoinsWithBalance(node.right);

            Moves += Math.Abs(left) + Math.Abs(right);

            int self = node.val - 1;

            return self + left + right;
        }
    }
}
