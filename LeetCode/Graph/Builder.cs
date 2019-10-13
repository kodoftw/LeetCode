using System;
using System.Collections.Generic;

namespace Graph
{
    public class Builder
    {
        public static Node CreateUndirectedGraph(IDictionary<int, IList<int>> adjList, int rootNode)
        {
            if (adjList == null || adjList.Count == 0)
            {
                return null;
            }

            var graph = new Dictionary<int, Node>();
            var visitedNodes = new HashSet<int>();
            var nodesToVisit = new Queue<int>(new[] { rootNode });

            while (nodesToVisit.Count > 0)
            {
                var node = nodesToVisit.Dequeue();
                if (visitedNodes.Contains(node))
                {
                    continue;
                }
                visitedNodes.Add(node);

                AddNodeToGraph(graph, node);

                var neighbors = adjList[node];
                foreach (var neighbor in neighbors)
                {
                    AddNodeToGraph(graph, neighbor);
                    AddNeighborToNode(graph, node, neighbor);
                    nodesToVisit.Enqueue(neighbor);
                }
            }

            return graph[rootNode];
        }

        private static void AddNodeToGraph(Dictionary<int, Node> graph, int node)
        {
            if (graph.ContainsKey(node))
            {
                return;
            }

            graph[node] = new Node(node, new List<Node>());
        }

        private static void AddNeighborToNode(Dictionary<int, Node> graph, int node, int neighbor)
        {
            if (!graph.ContainsKey(node))
            {
                throw new Exception("Cannot add neighbor to missing node.");
            }
            if (!graph.ContainsKey(neighbor))
            {
                throw new Exception("Cannot add missing neighbor to node.");
            }

            graph[node].neighbors.Add(graph[neighbor]);
        }
    }
}
