using BinaryTree;
using System.Collections.Generic;
using System.Linq;

namespace _637_AverageOfLevelsInBinaryTree
{
    internal class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null)
            {
                return new List<double>();
            }

            var list = new List<double>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                int count = queue.Count;
                double num = 0, sum = 0;

                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    num++;
                    sum += node.val;

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                list.Add(sum / num);
            }

            return list;
        }
    }
}
