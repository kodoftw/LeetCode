using System.Collections.Generic;
using System.Linq;

namespace _859_BuddyStrings
{
    internal class Solution
    {
        public bool BuddyStrings(string A, string B)
        {
            if (A.Length != B.Length)
                return false;

            var diffs = new int[2];
            int diffCount = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                    continue;

                if (diffCount == 2)
                    return false;

                diffs[diffCount] = i;
                diffCount++;
            }

            if (diffCount == 0)
            {
                return HasDuplicates(A);
            }

            return A[diffs[0]] == B[diffs[1]] && A[diffs[1]] == B[diffs[0]];
        }

        private bool HasDuplicates(string s)
        {
            var set = new HashSet<char>();
            return s.Any(x => !set.Add(x));
        }
    }
}
