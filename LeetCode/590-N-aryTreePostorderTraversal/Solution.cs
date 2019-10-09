using N_aryTree;
using System.Collections.Generic;

namespace _590_N_aryTreePostorderTraversal
{
    internal class Solution
    {
        public IList<int> Postorder(Node root)
        {
            var list = new List<int>();
            if (root == null)
            {
                return list;
            }

            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    list.AddRange(Postorder(child));
                }
            }

            list.Add(root.val);

            return list;
        }
    }
}
