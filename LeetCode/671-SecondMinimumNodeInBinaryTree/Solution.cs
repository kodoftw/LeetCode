using System;

namespace _671_SecondMinimumNodeInBinaryTree
{
    internal class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }
 
    internal class Solution
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            int minValue = root.val;

            int leftMinValue = FindSecondMinimumValue(root.left, minValue);
            int rightMinValue = FindSecondMinimumValue(root.right, minValue);

            int secondMinValue = SecondMinimumValue(leftMinValue, rightMinValue, minValue);
            if (secondMinValue == minValue)
            {
                return -1;
            }

            return secondMinValue;
        }

        private int FindSecondMinimumValue(TreeNode node, int minimumValue)
        {
            if (node == null)
            {
                return minimumValue;
            }

            if (node.val > minimumValue)
            {
                return node.val;
            }

            return SecondMinimumValue(
                FindSecondMinimumValue(node.left, minimumValue),
                FindSecondMinimumValue(node.right, minimumValue),
                minimumValue);
        }

        private int SecondMinimumValue(int a, int b, int minimumValue)
        {
            int min = Math.Min(a, b);

            if (min != minimumValue)
            {
                return min;
            }

            return Math.Max(a, b);
        }
    }
}
