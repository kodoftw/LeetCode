using BinaryTree;
using System;

namespace _783_MinimumDistanceBetweenBSTNodes
{
    class Solution
    {

        private int Res = int.MaxValue;
        private int? Last = null;

        public int MinDiffInBST(TreeNode root)
        {
            if (root.left != null)
            {
                MinDiffInBST(root.left);
            }
            if (Last.HasValue)
            {
                Res = Math.Min(Res, root.val - Last.Value);
            }
            Last = root.val;
            if (root.right != null)
            {
                MinDiffInBST(root.right);
            }
            return Res;
        }
    }
}
