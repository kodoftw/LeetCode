using System;

namespace _424_LongestRepeatingCharacterReplacement
{
    internal class Solution
    {
        public int CharacterReplacement(string s, int k)
        {
            var charCount = new int[26];
            int start = 0,
                end = 0,
                max = 0;

            while (end < s.Length)
            {
                var endChar = CharToInt(s[end]);
                charCount[endChar]++;
                max = Math.Max(max, charCount[endChar]);

                if (end - start >= max + k)
                {
                    var startChar = CharToInt(s[start]);
                    charCount[startChar]--;
                    start++;
                }

                end++;
            }


            return end - start;
        }

        private int CharToInt(char c)
        {
            return c - 'A';
        }
    }
}
