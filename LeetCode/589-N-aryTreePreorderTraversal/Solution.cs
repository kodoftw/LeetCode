using N_aryTree;
using System.Collections.Generic;

namespace _589_N_aryTreePreorderTraversal
{
    internal class Solution
    {
        public IList<int> Preorder(Node root)
        {
            var list = new List<int>();
            if (root == null)
            {
                return list;
            }

            list.Add(root.val);

            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    list.AddRange(Preorder(child));
                }
            }

            return list;
        }
    }
}
