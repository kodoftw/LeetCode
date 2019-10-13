using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    public class Printer
    {
        public static string PrintUndirectedGraph(Node root)
        {
            var nodesToVisit = new Queue<Node>();
            nodesToVisit.Enqueue(root);

            var visitedNodes = new HashSet<int>();

            var sb = new StringBuilder();
            sb.Append($"[{Environment.NewLine}");

            while (nodesToVisit.Count > 0)
            {
                var node = nodesToVisit.Dequeue();
                if (visitedNodes.Contains(node.val))
                {
                    continue;
                }
                visitedNodes.Add(node.val);

                PrintNode(sb, node);

                foreach (var neighbor in node.neighbors)
                {
                    nodesToVisit.Enqueue(neighbor);
                }
            }

            sb.Append("]");

            return sb.ToString();
        }

        private static void PrintNode(StringBuilder sb, Node node)
        {
            sb.Append($"  [{node.val}, [{string.Join(",", node.neighbors.Select(_ => _.val))}]]{Environment.NewLine}");
        }
    }
}
