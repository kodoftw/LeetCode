using BinaryTree;
using System.Collections.Generic;

namespace _257_BinaryTreePaths
{
    internal class Solution
    {
        private IList<string> AllPaths = new List<string>();

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root != null)
            {
                VisitChildrenAndPrintPaths(root, string.Empty);
            }

            return AllPaths;
        }

        private void VisitChildrenAndPrintPaths(TreeNode node, string path)
        {
            if (node.left == null && node.right == null)
            {
                AllPaths.Add($"{path}{node.val}");
                return;
            }

            var curPath = $"{path}{node.val}->";
            if (node.left != null)
                VisitChildrenAndPrintPaths(node.left, curPath);

            if (node.right != null)
                VisitChildrenAndPrintPaths(node.right, curPath);
        }
    }
}
