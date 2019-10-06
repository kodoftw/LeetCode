using BinaryTree;

namespace _404_SumOfLeftLeaves
{
    internal class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var leftValue = IsLeaf(root.left) ? root.left.val : 0;

            return leftValue + SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
        }

        private bool IsLeaf(TreeNode node)
        {
            return node != null && node.left == null && node.right == null;
        }
    }
}
