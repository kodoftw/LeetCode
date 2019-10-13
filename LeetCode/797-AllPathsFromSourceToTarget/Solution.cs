using System.Collections.Generic;

namespace _797_AllPathsFromSourceToTarget
{
    internal class Solution
    {
        private IList<IList<int>> paths = new List<IList<int>>();

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            AllPathsSourceTarget(graph, 0, new List<int>() { 0 });

            return paths;
        }

        private void AllPathsSourceTarget(int[][] graph, int curNode, IList<int> curPath)
        {
            if (curNode == graph.Length - 1)
            {
                paths.Add(new List<int>(curPath));
                return;
            }

            foreach (var node in graph[curNode])
            {
                curPath.Add(node);
                AllPathsSourceTarget(graph, node, curPath);
                curPath.RemoveAt(curPath.Count - 1);
            }
        }
    }
}
