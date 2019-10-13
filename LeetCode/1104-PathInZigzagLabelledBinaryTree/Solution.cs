using System.Collections.Generic;

namespace _1104_PathInZigzagLabelledBinaryTree
{
    internal class Solution
    {
        public IList<int> PathInZigZagTree(int label)
        {
            var height = GetLabelHeight(label);
            var path = new int[height + 1];
            bool isOdd = IsOdd(height + 1);

            for (; height >= 0; label >>= 1, height--, isOdd = !isOdd)
            {
                path[height] = label;

                int index = (1 << (height + 1)) - 1 - label;
                int heightBase = 1 << height;
                label = index + heightBase;
            }

            return path;
        }

        private int GetLabelHeight(int label)
        {
            int height = 0;
            int val = 1;
            while (val <= label)
            {
                height++;
                val <<= 1;
            }

            return height - 1;
        }

        private bool IsOdd(int n)
        {
            return (n & 1) == 1;
        }
    }
}
