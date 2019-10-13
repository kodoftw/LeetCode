using BinaryTree;
using System.Collections.Generic;
using System.Linq;

namespace _865_SmallestSubtreeWithAllTheDeepestNodes
{
    internal class Solution
    {
        private IDictionary<TreeNode, TreeNode> reverseLookup = new Dictionary<TreeNode, TreeNode>();

        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            var nodesOdd = new List<TreeNode>();
            var nodesEven = new List<TreeNode>() { root };

            IList<TreeNode> bottomNodes;

            int h = 0;
            for (; ; h++)
            {
                bool isEven = h % 2 == 0;

                var curNodes = isEven ? nodesEven : nodesOdd;
                var nodesToVisit = isEven ? nodesOdd : nodesEven;

                nodesToVisit.Clear();

                for (int i = 0; i < curNodes.Count; i++)
                {
                    var node = curNodes[i];

                    if (node.left != null)
                    {
                        nodesToVisit.Add(node.left);
                        reverseLookup.Add(node.left, node);
                    }
                    if (node.right != null)
                    {
                        nodesToVisit.Add(node.right);
                        reverseLookup.Add(node.right, node);
                    }
                }

                if (!nodesToVisit.Any())
                {
                    if (curNodes.Count == 1)
                    {
                        return curNodes[0];
                    }
                    break;
                }
            }



            for (; ; h--)
            {
                bool isEven = h % 2 == 0;

                var curNodes = isEven ? nodesEven : nodesOdd;
                var nodesToVisit = isEven ? nodesOdd : nodesEven;

                nodesToVisit.Clear();

                var hashset = new HashSet<int>();
                for (int i = 0; i < curNodes.Count; i++)
                {
                    if (!reverseLookup.ContainsKey(curNodes[i]))
                        continue;

                    var parent = reverseLookup[curNodes[i]];
                    if (hashset.Contains(parent.val))
                        continue;

                    nodesToVisit.Add(parent);
                    hashset.Add(parent.val);
                }

                if (!nodesToVisit.Any())
                {
                    return curNodes[0];
                }

                if (nodesToVisit.Count == 1)
                {
                    return nodesToVisit[0];
                }
            }
        }
    }
}
