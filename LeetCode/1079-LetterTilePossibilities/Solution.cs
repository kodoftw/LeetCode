using System.Collections.Generic;

namespace _1079_LetterTilePossibilities
{
    internal class Solution
    {
        public int NumTilePossibilities(string tiles)
        {
            if (tiles == string.Empty)
            {
                return 0;
            }

            var chosenChars = new HashSet<char>();

            int sum = 0;

            for (int i = 0; i < tiles.Length; i++)
            {
                var tile = tiles[i];

                if (!chosenChars.Contains(tile))
                {
                    sum += 1 + NumTilePossibilities(TilesWithoutTile(tiles, i));
                    chosenChars.Add(tile);
                }
            }

            return sum;
        }

        private string TilesWithoutTile(string tiles, int tileIndex)
        {
            return tiles.Substring(0, tileIndex) + tiles.Substring(tileIndex + 1);
        }
    }
}
