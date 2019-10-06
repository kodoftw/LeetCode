using System.Collections.Generic;

namespace _383_RansomNote
{
    internal class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (string.IsNullOrWhiteSpace(ransomNote))
            {
                return true;
            }

            var ransomCharCount = new Dictionary<char, int>();

            foreach (var c in ransomNote)
            {
                ransomCharCount[c] = ransomCharCount.ContainsKey(c) ? ransomCharCount[c] + 1 : 1;
            }

            foreach (var c in magazine)
            {
                if (!ransomCharCount.ContainsKey(c))
                {
                    continue;
                }

                if (ransomCharCount[c] == 1)
                {
                    ransomCharCount.Remove(c);
                    if (ransomCharCount.Keys.Count == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    ransomCharCount[c] = ransomCharCount[c] - 1;
                }
            }

            return false;
        }
    }
}
