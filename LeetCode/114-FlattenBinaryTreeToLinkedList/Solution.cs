using BinaryTree;

namespace _114_FlattenBinaryTreeToLinkedList
{
    internal class Solution
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Flatten(root.left);
            Flatten(root.right);

            if (root.left != null)
            {
                AppendRightToLeftBranch(root.left, root.right);
                root.right = root.left;
                root.left = null;
            }
        }

        private void AppendRightToLeftBranch(TreeNode left, TreeNode right)
        {
            while (left.right != null)
            {
                left = left.right;
            }

            left.right = right;
        }
    }
}
