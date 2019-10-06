using BinaryTree;
using System.Collections.Generic;

namespace _101_SymmetricTree
{
    internal class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var leftEnumerator = LeftTree(root.left).GetEnumerator();
            var rightEnumerator = RightTree(root.right).GetEnumerator();

            while (leftEnumerator.MoveNext() && rightEnumerator.MoveNext())
            {
                if (leftEnumerator.Current != rightEnumerator.Current)
                {
                    return false;
                }
            }

            return true;
        }

        private IEnumerable<int?> LeftTree(TreeNode node)
        {
            if (node == null)
            {
                yield return (int?)null;
                yield break;
            }

            yield return node.val;

            foreach (var child in LeftTree(node.left))
            {
                yield return child;
            }

            foreach (var child in LeftTree(node.right))
            {
                yield return child;
            }
        }

        private IEnumerable<int?> RightTree(TreeNode node)
        {
            if (node == null)
            {
                yield return (int?)null;
                yield break;
            }

            yield return node.val;

            foreach (var child in RightTree(node.right))
            {
                yield return child;
            }
            foreach (var child in RightTree(node.left))
            {
                yield return child;
            }
        }
    }
}
