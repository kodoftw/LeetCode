using BinaryTree;
using System.Collections.Generic;

namespace _653_TwoSumIV_InputIsBST
{
    internal class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            return FindTargetWithSet(root, k, new HashSet<int>());
        }

        private bool FindTargetWithSet(TreeNode root, int k, HashSet<int> set)
        {
            if (root == null)
            {
                return false;
            }

            if (set.Contains(k - root.val))
            {
                return true;
            }

            set.Add(root.val);

            return FindTargetWithSet(root.left, k, set) || FindTargetWithSet(root.right, k, set);
        }
    }
}
