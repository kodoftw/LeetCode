using BinaryTree;
using System.Collections.Generic;

namespace _897_IncreasingOrderSearchTree
{
    internal class Solution
    {
        public TreeNode IncreasingBST(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            var traverse = GetEnumerable(root).GetEnumerator();

            traverse.MoveNext();
            var ret = new TreeNode(traverse.Current);
            var current = ret;

            while (traverse.MoveNext())
            {
                var newNode = new TreeNode(traverse.Current);
                current.right = newNode;
                current = newNode;
            }

            return ret;
        }

        private IEnumerable<int> GetEnumerable(TreeNode root)
        {
            if (root.left != null)
            {
                foreach (var value in GetEnumerable(root.left))
                {
                    yield return value;
                }
            }

            yield return root.val;

            if (root.right != null)
            {
                foreach (var value in GetEnumerable(root.right))
                {
                    yield return value;
                }
            }
        }
    }
}
