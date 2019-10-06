using BinaryTree;

namespace _538_ConvertBSTToGreaterTree
{
    internal class Solution
    {
        private int Sum = 0;

        public TreeNode ConvertBST(TreeNode root)
        {
            GreaterBST(root);
            return root;
        }

        private void GreaterBST(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            GreaterBST(root.right);
            Sum += root.val;
            root.val = Sum;
            GreaterBST(root.left);

        }
    }
}
