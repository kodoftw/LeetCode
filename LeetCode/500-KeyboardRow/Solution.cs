using System.Collections.Generic;

namespace _500_KeyboardRow
{
    internal class Solution
    {
        public string[] FindWords(string[] words)
        {
            var charToRow = GetCharToRowDictionary();

            var canBeTypedWords = new List<string>();

            foreach (var word in words)
            {
                if (IsSameRow(word.ToLower(), charToRow))
                {
                    canBeTypedWords.Add(word);
                }
            }

            return canBeTypedWords.ToArray();
        }

        private bool IsSameRow(string w, IDictionary<char, int> charToRow)
        {
            if (w.Length == 1)
                return true;

            if (charToRow[w[0]] != charToRow[w[1]])
                return false;

            return IsSameRow(w.Substring(1), charToRow);
        }

        private IDictionary<char, int> GetCharToRowDictionary()
        {
            return new Dictionary<char, int>() {
            {'q', 0 },
            {'w', 0 },
            {'e', 0 },
            {'r', 0 },
            {'t', 0 },
            {'y', 0 },
            {'u', 0 },
            {'i', 0 },
            {'o', 0 },
            {'p', 0 },
            {'a', 1 },
            {'s', 1 },
            {'d', 1 },
            {'f', 1 },
            {'g', 1 },
            {'h', 1 },
            {'j', 1 },
            {'k', 1 },
            {'l', 1 },
            {'z', 2 },
            {'x', 2 },
            {'c', 2 },
            {'v', 2 },
            {'b', 2 },
            {'n', 2 },
            {'m', 2 }
        };
        }
    }
}
