using System;
using System.Collections.Generic;
using System.Text;

namespace _557_ReverseWordsInAStringIII
{
    internal class Solution
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }
            var words = s.Split(' ');
            var reverseWords = new List<string>();

            foreach (var word in words)
            {
                reverseWords.Add(Reverse(word));
            }

            return string.Join(" ", reverseWords);
        }

        private string Reverse(string s)
        {
            var sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
