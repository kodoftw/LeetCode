using System.Collections.Generic;

namespace _437_PathSumIII
{
    internal class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    internal class Solution
    {
        private IDictionary<int, int> PartialPathSum = new Dictionary<int, int>();

        public int PathSum(TreeNode root, int sum)
        {
            PartialPathSum[0] = 1;
            return PrefixSum(root, sum, 0);
        }

        private int PrefixSum(TreeNode node, int target, int sum)
        {
            if (node == null)
            {
                return 0;
            }

            sum += node.val;
            int paths = GetValueOrDefault(sum - target, 0);
            PartialPathSum[sum] = GetValueOrDefault(sum, 0) + 1;

            paths += PrefixSum(node.left, target, sum) + PrefixSum(node.right, target, sum);
            PartialPathSum[sum] = PartialPathSum[sum] - 1;

            return paths;
        }

        private int GetValueOrDefault(int key, int defaultValue)
        {
            return PartialPathSum.ContainsKey(key) ? PartialPathSum[key] : defaultValue;
        }
    }
}
