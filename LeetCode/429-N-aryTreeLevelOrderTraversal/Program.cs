using N_aryTree;
using System.Collections.Generic;
using Xunit;

namespace _429_N_aryTreeLevelOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Assert.Equal(
                new List<List<int>> { new List<int> { 1 }, new List<int> { 3, 2, 4 }, new List<int> { 5, 6 } },
                solution.LevelOrder(new Node(1, new List<Node>{
                    new Node(3, new List<Node> { new Node(5, null), new Node(6, null) }),
                    new Node(2, null),
                    new Node(4, null) })));
        }
    }
}
