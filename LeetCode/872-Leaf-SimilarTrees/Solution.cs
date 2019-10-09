using BinaryTree;
using System.Collections.Generic;

namespace _872_Leaf_SimilarTrees
{
    internal class Solution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leaves1 = FindLeavesPreorder(root1).GetEnumerator();
            var leaves2 = FindLeavesPreorder(root2).GetEnumerator();

            while (leaves1.MoveNext() && leaves2.MoveNext())
            {
                if (leaves1.Current != leaves2.Current)
                {
                    return false;
                }
            }

            return true;
        }

        private IEnumerable<int> FindLeavesPreorder(TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                yield return node.val;
            }

            if (node.left != null)
            {
                foreach (var x in FindLeavesPreorder(node.left))
                {
                    yield return x;
                }
            }

            if (node.right != null)
            {
                foreach (var x in FindLeavesPreorder(node.right))
                {
                    yield return x;
                }
            }
        }
    }
}
