using BinaryTree;
using System.Collections.Generic;

namespace _654_MaximumBinaryTree
{
    internal class Solution
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            var decNodeStack = new Stack<TreeNode>();

            for (int i = 0; i < nums.Length; i++)
            {
                var node = new TreeNode(nums[i]);
                while (decNodeStack.Count > 0 && decNodeStack.Peek().val < nums[i])
                {
                    node.left = decNodeStack.Pop();
                }

                if (decNodeStack.Count > 0)
                    decNodeStack.Peek().right = node;

                decNodeStack.Push(node);
            }

            while (decNodeStack.Count > 1) decNodeStack.Pop();

            return decNodeStack.Pop();
        }
    }
}
