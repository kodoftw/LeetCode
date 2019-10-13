using BinaryTree;

namespace _1008_ConstructBinarySearchTreeFromPreorderTraversal
{
    internal class Solution
    {
        private int[] Preorder;
        private int i = 0;

        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder.Length == 0)
            {
                return null;
            }

            Preorder = preorder;

            return BstFromPreorder(int.MaxValue);
        }

        private TreeNode BstFromPreorder(int limitVal)
        {
            if (i >= Preorder.Length || Preorder[i] > limitVal)
                return null;

            var node = new TreeNode(Preorder[i++]);
            node.left = BstFromPreorder(node.val);
            node.right = BstFromPreorder(limitVal);

            return node;
        }
    }
}
