using System;

namespace _132_PalindromePartitioningII
{
    internal class Solution
    {
        private int[] Cuts;
        private string S;

        public int MinCut(string s)
        {
            S = s;
            InitializeCutsArray();

            for (int i = 0; i < s.Length; i++)
            {
                CheckOddPalindrome(i);
                CheckEvenPalindrome(i);
            }

            return Cuts[s.Length];
        }

        private void InitializeCutsArray()
        {
            Cuts = new int[S.Length + 1];
            for (int i = 0; i < S.Length + 1; i++)
            {
                Cuts[i] = i - 1;
            }
        }

        private void CheckOddPalindrome(int center)
        {
            for (int radius = 0;
                 center - radius >= 0 && center + radius < S.Length && S[center - radius] == S[center + radius];
                 radius++)
            {
                Cuts[center + radius + 1] = Math.Min(Cuts[center + radius + 1], Cuts[center - radius] + 1);
            }
        }

        private void CheckEvenPalindrome(int center)
        {
            for (int radius = 1;
                 center - radius + 1 >= 0 && center + radius < S.Length && S[center - radius + 1] == S[center + radius];
                 radius++)
            {
                Cuts[center + radius + 1] = Math.Min(Cuts[center + radius + 1], Cuts[center - radius + 1] + 1);
            }
        }
    }
}
