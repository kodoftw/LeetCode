using System.Collections.Generic;

namespace _890_FindAndReplacePattern
{
    internal class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var matches = new List<string>();

            foreach (var word in words)
            {
                if (pattern.Length != word.Length)
                    continue;

                var patternHash = new int[26];
                var wordHash = new int[26];
                bool match = true;

                for (int i = 0; i < pattern.Length; i++)
                {
                    var indexPattern = CharToInt(pattern[i]);
                    var indexWord = CharToInt(word[i]);

                    if (patternHash[indexPattern] != wordHash[indexWord])
                    {
                        match = false;
                        break;
                    }

                    patternHash[indexPattern] += i + 1;
                    wordHash[indexWord] += i + 1;
                }

                if (match)
                    matches.Add(word);
            }

            return matches;
        }

        private int CharToInt(char c)
        {
            return c - 'a';
        }
    }
}
