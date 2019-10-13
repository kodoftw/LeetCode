﻿using BinaryTree;

namespace _814_BinaryTreePruning
{
    internal class Solution
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null)
                return null;

            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);

            if (root.val == 0 && root.left == null && root.right == null)
                return null;

            return root;
        }
    }
}
