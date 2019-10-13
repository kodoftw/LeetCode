using System.Collections.Generic;

namespace _140_WordBreakII
{
    internal class Solution
    {
        private IDictionary<string, IList<string>> VisitedWords;

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            VisitedWords = new Dictionary<string, IList<string>>();

            return WordBreakDFS(s, wordDict);
        }

        private IList<string> WordBreakDFS(string s, IList<string> wordDict)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return new List<string>();
            }

            if (VisitedWords.ContainsKey(s))
            {
                return VisitedWords[s];
            }

            var sentences = new List<string>();
            foreach (var word in wordDict)
            {
                if (s == word)
                {
                    sentences.Add(s);
                }
                else if (s.StartsWith(word))
                {
                    var remainingString = s.Substring(word.Length, s.Length - word.Length);
                    var combinations = WordBreakDFS(remainingString, wordDict);
                    foreach (var combination in combinations)
                    {
                        sentences.Add($"{word} {combination}");
                    }
                }
            }

            VisitedWords.Add(s, sentences);
            return sentences;
        }
    }
}
