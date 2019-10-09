using System.Collections.Generic;

namespace _566_ReshapeTheMatrix
{
    internal class Solution
    {
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            int numRows = nums.GetLength(0);
            int numCols = nums.GetLength(1);

            if (numRows * numCols != r * c)
            {
                return nums;
            }

            var ret = new int[r, c];

            var enumerable = GetEnumerable(nums, numRows, numCols).GetEnumerator();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    enumerable.MoveNext();
                    ret[i, j] = enumerable.Current;
                }
            }

            return ret;
        }

        private IEnumerable<int> GetEnumerable(int[,] nums, int numRows, int numCols)
        {
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    yield return nums[i, j];
                }
            }
        }
    }
}
