using N_aryTree;

namespace _559_MaximumDepthOfN_aryTree
{
    internal class Solution
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int childrenDepth = 0;
            if (root.children != null && root.children.Count > 0)
            {
                for (int i = 0; i < root.children.Count; i++)
                {
                    var childDepth = MaxDepth(root.children[i]);
                    if (childDepth > childrenDepth)
                    {
                        childrenDepth = childDepth;
                    }
                }
            }

            return childrenDepth + 1;
        }
    }
}
