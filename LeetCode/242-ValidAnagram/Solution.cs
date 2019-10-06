using System.Linq;

namespace _242_ValidAnagram
{
    internal class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var count = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                count[(int)s[i] - 97]++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                count[(int)t[i] - 97]--;
            }

            return count.All(_ => _ == 0);
        }
    }
}
