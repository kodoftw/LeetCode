using System.Collections.Generic;

namespace BinaryTree
{
    public class Builder
    {
        public static TreeNode CreateTree(int?[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

            var treeNodeQueue = new Queue<TreeNode>();
            var integerQueue = new Queue<int?>();
            for (int i = 1; i < array.Length; i++)
            {
                integerQueue.Enqueue(array[i]);
            }

            var treeNode = new TreeNode(array[0].Value);
            treeNodeQueue.Enqueue(treeNode);

            while (integerQueue.Count > 0)
            {
                var leftVal = integerQueue.Count == 0 ? null : integerQueue.Dequeue();
                var rightVal = integerQueue.Count == 0 ? null : integerQueue.Dequeue();
                var currentNode = treeNodeQueue.Dequeue();

                if (leftVal.HasValue)
                {
                    var left = new TreeNode(leftVal.Value);
                    currentNode.left = left;
                    treeNodeQueue.Enqueue(left);
                }

                if (rightVal.HasValue)
                {
                    var right = new TreeNode(rightVal.Value);
                    currentNode.right = right;
                    treeNodeQueue.Enqueue(right);
                }
            }
            return treeNode;
        }
    }
}
