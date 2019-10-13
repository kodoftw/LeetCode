using System;
using System.Collections.Generic;
using System.Linq;

namespace _934_ShortestBridge
{
    internal class Solution
    {
        private Queue<(int, int)> Lands = new Queue<(int, int)>();

        public int ShortestBridge(int[][] A)
        {
            Lands.Clear();
            (int i, int j) = FindFirstIsland(A);
            MarkFirstIsland(A, i, j);

            return ExpandUntilConnected(A);
        }

        private (int, int) FindFirstIsland(int[][] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] == 1)
                        return (i, j);
                }
            }

            throw new Exception("No land found");
        }

        private void MarkFirstIsland(int[][] A, int i, int j)
        {
            if (IsOutOfBounds(A, i, j) || A[i][j] != 1)
                return;

            Lands.Enqueue((i, j));
            A[i][j] = 2;

            MarkFirstIsland(A, i - 1, j);
            MarkFirstIsland(A, i + 1, j);
            MarkFirstIsland(A, i, j - 1);
            MarkFirstIsland(A, i, j + 1);
        }

        private bool IsOutOfBounds(int[][] A, int i, int j)
        {
            return i < 0 || j < 0 || i >= A.Length || j >= A[i].Length;
        }

        private int ExpandUntilConnected(int[][] A)
        {
            while (Lands.Any())
            {
                var (i, j) = Lands.Dequeue();
                var landValue = A[i][j];

                if (NearOtherIsland(A, i, j))
                {
                    return landValue - 2;
                }

                ExpandIsland(A, i - 1, j, landValue);
                ExpandIsland(A, i + 1, j, landValue);
                ExpandIsland(A, i, j - 1, landValue);
                ExpandIsland(A, i, j + 1, landValue);
            }

            return 0;
        }

        private bool NearOtherIsland(int[][] A, int i, int j)
        {
            return IsOtherIsland(A, i - 1, j)
                || IsOtherIsland(A, i + 1, j)
                || IsOtherIsland(A, i, j - 1)
                || IsOtherIsland(A, i, j + 1);
        }

        private bool IsOtherIsland(int[][] A, int i, int j)
        {
            if (IsOutOfBounds(A, i, j))
                return false;

            return A[i][j] == 1;
        }

        private void ExpandIsland(int[][] A, int i, int j, int landValue)
        {
            if (IsOutOfBounds(A, i, j))
                return;

            if (A[i][j] == 0)
            {
                A[i][j] = landValue + 1;
                Lands.Enqueue((i, j));
            }
        }
    }
}
