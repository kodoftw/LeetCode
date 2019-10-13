using BinaryTree;

namespace _951_FlipEquivalentBinaryTrees
{
    internal class Solution
    {
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if (root1 == null || root2 == null)
                return false;

            if (SameChildren(root1, root2))
            {
                return FlipEquiv(root1.left, root2.left)
                    && FlipEquiv(root1.right, root2.right);
            }

            if (FlippedChildren(root1, root2))
            {
                return FlipEquiv(root1.left, root2.right)
                    && FlipEquiv(root1.right, root2.left);
            }

            return false;
        }

        private bool SameChildren(TreeNode node1, TreeNode node2)
        {
            return SameNode(node1.left, node2.left)
                && SameNode(node2.right, node2.right);
        }

        private bool SameNode(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1 == null || node2 == null)
                return false;

            return node1.val == node2.val;
        }

        private bool FlippedChildren(TreeNode node1, TreeNode node2)
        {
            return SameNode(node1.left, node2.right)
                && SameNode(node1.right, node2.left);
        }
    }
}
