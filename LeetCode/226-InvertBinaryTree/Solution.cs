using BinaryTree;

namespace _226_InvertBinaryTree
{
    internal class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var temp = InvertTree(root.left);
            root.left = InvertTree(root.right);
            root.right = temp;

            return root;
        }
    }
}
