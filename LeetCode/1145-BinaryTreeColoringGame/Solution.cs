using BinaryTree;
using System;

namespace _1145_BinaryTreeColoringGame
{
    internal class Solution
    {
        public bool BtreeGameWinningMove(TreeNode root, int n, int x)
        {
            var firstPlayerNode = FindNodeByValue(root, x);
            var leftChildren = CountChildren(firstPlayerNode.left);
            var rightChildren = CountChildren(firstPlayerNode.right);

            int nodesIfChoosingParent = n - leftChildren - rightChildren - 1;

            return Math.Max(Math.Max(leftChildren, rightChildren), nodesIfChoosingParent) > n / 2;
        }

        private TreeNode FindNodeByValue(TreeNode node, int val)
        {
            if (node == null)
            {
                return null;
            }
            if (node.val == val)
            {
                return node;
            }

            return FindNodeByValue(node.left, val)
                ?? FindNodeByValue(node.right, val);
        }

        private int CountChildren(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + CountChildren(node.left) + CountChildren(node.right);
        }
    }
}
