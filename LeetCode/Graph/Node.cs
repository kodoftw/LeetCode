using System.Collections.Generic;

namespace Graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node(int x, IList<Node> _neighbors)
        {
            val = x;
            neighbors = _neighbors;
        }
    }
}
