using System.Collections.Generic;
using System.Linq;

namespace _785_IsGraphBipartite
{
    internal class Solution
    {
        private enum Colors
        {
            Uncolored = 0,
            Red = 1,
            Blue = 2
        }

        private Colors[] ColoredNodes;

        public bool IsBipartite(int[][] graph)
        {
            ColoredNodes = new Colors[graph.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                if (graph[i].Length == 0 || ColoredNodes[i] != Colors.Uncolored)
                {
                    continue;
                }

                ColoredNodes[i] = Colors.Red;

                var queue = new Queue<int>();
                queue.Enqueue(i);

                while (queue.Any())
                {
                    var node = queue.Dequeue();

                    for (int n = 0; n < graph[node].Length; n++)
                    {
                        int neighbor = graph[node][n];

                        if (ColoredNodes[neighbor] == Colors.Uncolored)
                        {
                            ColorNeighbor(neighbor, ColoredNodes[node]);
                            queue.Enqueue(neighbor);
                        }
                        else if (ColoredNodes[node] == ColoredNodes[neighbor])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void ColorNeighbor(int neighbor, Colors nodeColor)
        {
            var color = nodeColor == Colors.Red ? Colors.Blue : Colors.Red;

            ColoredNodes[neighbor] = color;
        }
    }
}
