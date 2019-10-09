using BinaryTree;

namespace _669_TrimABinarySearchTree
{
    internal class Solution
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return null;

            if (root.val < L)
            {
                root = root.right;
                return TrimBST(root, L, R);
            }
            else if (root.val > R)
            {
                root = root.left;
                return TrimBST(root, L, R);
            }

            if (root != null)
            {
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
            }

            return root;
        }
    }
}
