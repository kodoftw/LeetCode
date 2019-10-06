using BinaryTree;
using System;

namespace _530_MinimumAbsoluteDifferenceInBST
{
    internal class Solution
    {
        private int Res = int.MaxValue;
        private int? Last = null;

        public int GetMinimumDifference(TreeNode root)
        {
            if (root.left != null)
            {
                GetMinimumDifference(root.left);
            }
            if (Last.HasValue)
            {
                Res = Math.Min(Res, root.val - Last.Value);
            }
            Last = root.val;
            if (root.right != null)
            {
                GetMinimumDifference(root.right);
            }
            return Res;
        }
    }
}
