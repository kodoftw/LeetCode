using N_aryTree;
using System.Collections.Generic;

namespace _429_N_aryTreeLevelOrderTraversal
{
    internal class Solution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var dict = new Dictionary<int, IList<int>>();
            LevelOrder(root, 0, dict);

            int i = 0;
            var list = new List<IList<int>>();
            while (dict.ContainsKey(i))
            {
                list.Add(dict[i]);
                i++;
            }

            return list;
        }

        private void LevelOrder(Node root, int level, IDictionary<int, IList<int>> dict)
        {
            if (root == null)
            {
                return;
            }

            if (dict.ContainsKey(level))
            {
                dict[level].Add(root.val);
            }
            else
            {
                dict[level] = new List<int>() { root.val };
            }

            if (root.children != null)
            {
                foreach (var child in root.children)
                {
                    LevelOrder(child, level + 1, dict);
                }
            }
        }
    }
}
