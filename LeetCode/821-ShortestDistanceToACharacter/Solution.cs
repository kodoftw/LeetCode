using System;

namespace _821_ShortestDistanceToACharacter
{
    internal class Solution
    {
        public int[] ShortestToChar(string S, char C)
        {
            var ret = new int[S.Length];
            int dist = S.Length;

            for (int i = 0; i < S.Length; i++)
            {
                dist = S[i] == C ? 0 : dist + 1;

                ret[i] = dist;
            }

            for (int i = S.Length - 1; i >= 0; i--)
            {
                dist = S[i] == C ? 0 : dist + 1;

                ret[i] = Math.Min(ret[i], dist);
            }

            return ret;
        }
    }
}
