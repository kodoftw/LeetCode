using System;

namespace _419_BattleshipsInABoard
{
    internal class Solution
    {
        public int CountBattleships(char[][] board)
        {
            int sum = 0;

            VisitBoard(board, (i, j) => {
                if (board[i][j] == 'X'
                    && (i == 0 || board[i - 1][j] != 'X')
                    && (j == 0 || board[i][j - 1] != 'X'))
                {
                    sum++;
                }
            });

            return sum;
        }

        private void VisitBoard(char[][] board, Action<int, int> action)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    action(i, j);
                }
            }
        }
    }
}
