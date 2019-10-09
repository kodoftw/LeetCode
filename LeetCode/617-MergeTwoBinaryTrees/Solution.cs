using BinaryTree;

namespace _617_MergeTwoBinaryTrees
{
    internal class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;

            var newTree = new TreeNode((t1?.val ?? 0) + (t2?.val ?? 0));
            newTree.left = MergeTrees(t1?.left, t2?.left);
            newTree.right = MergeTrees(t1?.right, t2?.right);

            return newTree;
        }
    }
}
