using N_aryTree;
using System.Collections.Generic;
using Xunit;

namespace _559_MaximumDepthOfN_aryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var root = new Node(1, new List<Node>
            {
                new Node(3, new List<Node> { new Node(5, null), new Node(6, null) }),
                new Node(2, null),
                new Node(4, null)
            });
            Assert.Equal(3, solution.MaxDepth(root));
        }
    }
}
