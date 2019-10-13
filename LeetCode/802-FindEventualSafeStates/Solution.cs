using System.Collections.Generic;

namespace _802_FindEventualSafeStates
{
    internal class Solution
    {
        private enum NodeState
        {
            Safe,
            Unsafe
        }

        private int[][] Graph;
        private NodeState?[] States;

        public IList<int> EventualSafeNodes(int[][] graph)
        {
            Graph = graph;
            States = new NodeState?[graph.Length];
            var safeNodes = new List<int>();

            for (int i = 0; i < graph.Length; i++)
            {
                if (IsSafe(i))
                {
                    safeNodes.Add(i);
                }
            }

            return safeNodes;
        }

        private bool IsSafe(int node)
        {
            if (States[node] != null)
            {
                return States[node] == NodeState.Safe;
            }

            States[node] = NodeState.Unsafe;

            foreach (var neighbor in Graph[node])
            {
                if (!IsSafe(neighbor))
                {
                    return false;
                }
            }

            States[node] = NodeState.Safe;

            return true;
        }
    }
}
