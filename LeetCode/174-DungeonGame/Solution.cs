using System;

namespace _174_DungeonGame
{
    internal class Solution
    {
        private int?[][] VisitedRoomsHealth;
        private int[][] Dungeon;

        public int CalculateMinimumHP(int[][] dungeon)
        {
            Dungeon = dungeon;
            InitVisitedRoomsHealth();
            VisitRooms();

            return VisitedRoomsHealth[0][0].Value;
        }

        private void InitVisitedRoomsHealth()
        {
            VisitedRoomsHealth = new int?[Dungeon.Length + 1][];

            for (int i = 0; i < VisitedRoomsHealth.Length; i++)
            {
                VisitedRoomsHealth[i] = new int?[Dungeon[0].Length + 1];
            }

            VisitedRoomsHealth[Dungeon.Length][Dungeon[0].Length - 1] = 1;
            VisitedRoomsHealth[Dungeon.Length - 1][Dungeon[0].Length] = 1;
        }

        private void VisitRooms()
        {
            for (int row = Dungeon.Length - 1; row >= 0; row--)
            {
                for (int col = Dungeon[0].Length - 1; col >= 0; col--)
                {
                    int currentMinHealth = Math.Min(GetRoomHealth(row + 1, col), GetRoomHealth(row, col + 1));
                    int newMinHealth = currentMinHealth - Dungeon[row][col];

                    VisitedRoomsHealth[row][col] = Math.Max(1, newMinHealth);
                }
            }
        }

        private int GetRoomHealth(int row, int col)
        {
            if (row < VisitedRoomsHealth.Length && col < VisitedRoomsHealth[0].Length)
            {
                return VisitedRoomsHealth[row][col] ?? Int32.MaxValue;
            }

            return Int32.MaxValue;
        }
    }
}
