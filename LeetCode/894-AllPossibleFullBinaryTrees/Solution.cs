using BinaryTree;
using System.Collections.Generic;

namespace _894_AllPossibleFullBinaryTrees
{
    internal class Solution
    {
        public IList<TreeNode> AllPossibleFBT(int N)
        {
            if (N < 0)
                return new List<TreeNode>();

            if (N == 1)
                return new List<TreeNode>() { new TreeNode(0) };

            var fbts = new List<TreeNode>();
            for (int i = 1; i <= N - 2; i += 2)
            {
                var leftFbts = AllPossibleFBT(i);
                var rightFbts = AllPossibleFBT(N - i - 1);

                foreach (var leftFbt in leftFbts)
                {
                    foreach (var rightFbt in rightFbts)
                    {
                        var fbt = new TreeNode(0);
                        fbt.left = leftFbt;
                        fbt.right = rightFbt;

                        fbts.Add(fbt);
                    }
                }
            }

            return fbts;
        }
    }
}
