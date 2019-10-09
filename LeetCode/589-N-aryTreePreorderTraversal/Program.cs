using N_aryTree;
using System.Collections.Generic;
using Xunit;

namespace _589_N_aryTreePreorderTraversal
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
            Assert.Equal(new List<int> { 1, 3, 5, 6, 2, 4 }, solution.Preorder(root));
        }
    }
}
