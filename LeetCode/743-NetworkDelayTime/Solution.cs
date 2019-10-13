using System;
using System.Collections.Generic;
using System.Linq;

namespace _743_NetworkDelayTime
{
    internal class Solution
    {
        public int NetworkDelayTime(int[][] times, int N, int K)
        {
            var dist = new int?[N];
            var enqueued = new bool[N];
            var adjList = new IList<int>[N];
            for (int i = 0; i < times.Length; i++)
            {
                var u = times[i][0] - 1;

                if (adjList[u] == null)
                {
                    adjList[u] = new List<int>();
                }
                adjList[u].Add(i);
            }

            dist[K - 1] = 0;
            var q = new Queue<int>();
            q.Enqueue(K - 1);
            enqueued[K - 1] = true;

            while (q.Any())
            {
                var u = q.Dequeue();
                enqueued[u] = false;
                if (adjList[u] == null)
                {
                    continue;
                }
                foreach (var edgeIndex in adjList[u])
                {
                    var edge = times[edgeIndex];
                    var v = edge[1] - 1;
                    var w = edge[2];

                    if (!dist[v].HasValue || dist[u] + w < dist[v])
                    {
                        dist[v] = dist[u] + w;
                        if (!enqueued[v])
                        {
                            q.Enqueue(v);
                            enqueued[v] = true;
                        }
                    }
                }
            }

            var max = -1;
            for (int i = 0; i < dist.Length; i++)
            {
                if (!dist[i].HasValue)
                {
                    return -1;
                }
                if (i == K - 1)
                {
                    continue;
                }

                max = Math.Max(max, dist[i].Value);
            }

            return max;
        }
    }
}
