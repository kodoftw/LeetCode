using BinaryTree;

namespace _1038_BinarySearchTreeToGreaterSumTree
{
    internal class Solution
    {
        int sum = 0;

        public TreeNode BstToGst(TreeNode root)
        {
            ToGst(root);

            return root;
        }

        private void ToGst(TreeNode node)
        {
            if (node == null)
                return;

            ToGst(node.right);

            sum += node.val;
            node.val = sum;

            ToGst(node.left);
        }
    }
}
