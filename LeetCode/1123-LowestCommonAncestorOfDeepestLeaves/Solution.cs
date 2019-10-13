using BinaryTree;

namespace _1123_LowestCommonAncestorOfDeepestLeaves
{
    internal class Solution
    {
        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            var (node, _) = LcaDeepestLeavesWithHeight(root, 0);

            return node;
        }

        private (TreeNode, int) LcaDeepestLeavesWithHeight(TreeNode node, int height)
        {
            if (node == null)
            {
                return (null, -1);
            }
            if (node.left == null && node.right == null)
            {
                return (node, height);
            }

            var (leftLca, heightLeft) = LcaDeepestLeavesWithHeight(node.left, height + 1);
            var (rightLca, heightRight) = LcaDeepestLeavesWithHeight(node.right, height + 1);

            if (heightLeft == heightRight)
            {
                return (node, heightLeft);
            }
            else if (heightLeft > heightRight)
            {
                return (leftLca, heightLeft);
            }
            else
            {
                return (rightLca, heightRight);
            }
        }
    }
}
