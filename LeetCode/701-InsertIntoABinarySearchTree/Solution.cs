using BinaryTree;

namespace _701_InsertIntoABinarySearchTree
{
    internal class Solution
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            var node = CreateNode(val);
            if (root == null)
            {
                return node;
            }

            InsertNodeIntoBST(root, node);

            return root;
        }

        private TreeNode CreateNode(int val)
        {
            return new TreeNode(val);
        }

        private void InsertNodeIntoBST(TreeNode node, TreeNode nodeToInsert)
        {
            var val = nodeToInsert.val;
            if (node.val > val)
            {
                if (node.left == null)
                {
                    node.left = nodeToInsert;
                    return;
                }

                InsertNodeIntoBST(node.left, nodeToInsert);
                return;
            }

            if (node.right == null)
            {
                node.right = nodeToInsert;
                return;
            }

            InsertNodeIntoBST(node.right, nodeToInsert);
        }
    }
}
