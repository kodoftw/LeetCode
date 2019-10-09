namespace _867_TransposeMatrix
{
    internal class Solution
    {
        public int[][] Transpose(int[][] A)
        {
            int rows = A.Length;
            int cols = A[0].Length;

            int[][] ret = new int[cols][];

            for (int i = 0; i < cols; i++)
            {
                ret[i] = new int[rows];
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    ret[j][i] = A[i][j];
                }
            }

            return ret;
        }
    }
}
