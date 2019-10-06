using System.Collections.Generic;

namespace _796_RotateString
{
    internal class Solution
    {
        public bool RotateString(string A, string B)
        {
            if (string.IsNullOrWhiteSpace(A) || string.IsNullOrWhiteSpace(B)) return A == B;
            if (A.Length != B.Length) return false;

            var indexes = new List<int>();

            for (int i = B.IndexOf(A[0]); i > -1; i = B.IndexOf(A[0], i + 1))
            {
                indexes.Add(i);
            }

            foreach (var idx in indexes)
            {
                bool equal = true;
                var index = idx;
                for (int i = 0; i < A.Length; i++, index++)
                {
                    index = index % A.Length;

                    if (A[i] != B[index])
                    {
                        equal = false;
                        break;
                    }
                }

                if (equal)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
