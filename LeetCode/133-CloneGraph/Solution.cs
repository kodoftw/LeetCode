using Graph;
using System;
using System.Collections.Generic;

namespace _133_CloneGraph
{
    internal class Solution
    {
        private IDictionary<int, Node> Graph = new Dictionary<int, Node>();
        private HashSet<int> VisitedNodes = new HashSet<int>();
        private Queue<Node> NodesToVisit = new Queue<Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }

            NodesToVisit.Enqueue(node);

            while (SomeNodeWasNotVisited())
            {
                var currentNode = NodesToVisit.Dequeue();
                if (NodeWasVisited(currentNode))
                {
                    continue;
                }
                VisitNode(currentNode);
            }

            return Graph[node.val];
        }

        private bool SomeNodeWasNotVisited()
        {
            return NodesToVisit.Count > 0;
        }

        private void VisitNode(Node currentNode)
        {
            VisitedNodes.Add(currentNode.val);

            AddNodeToGraph(currentNode.val);

            foreach (var neighbor in currentNode.neighbors)
            {
                AddNodeToGraph(neighbor.val);
                AddNeighborToNode(currentNode.val, neighbor.val);
                NodesToVisit.Enqueue(neighbor);
            }
        }

        private bool NodeWasVisited(Node currentNode)
        {
            return VisitedNodes.Contains(currentNode.val);
        }

        private void AddNodeToGraph(int node)
        {
            if (Graph.ContainsKey(node))
            {
                return;
            }

            Graph[node] = new Node(node, new List<Node>());
        }

        private void AddNeighborToNode(int node, int neighbor)
        {
            if (!Graph.ContainsKey(node))
            {
                throw new Exception("Cannot add neighbor to missing node.");
            }
            if (!Graph.ContainsKey(neighbor))
            {
                throw new Exception("Cannot add missing neighbor to node.");
            }

            Graph[node].neighbors.Add(Graph[neighbor]);
        }
    }
}
