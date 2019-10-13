using System.Collections.Generic;
using System.Linq;

namespace _127_WordLadder
{
    internal class Solution
    {
        private HashSet<string> Words;
        private Queue<string> WordQueue;
        private char[] AllChars = new char[26] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            int ladderLength = 1;

            Words = new HashSet<string>(wordList);
            if (!Words.Contains(endWord))
                return 0;

            WordQueue = new Queue<string>();
            WordQueue.Enqueue(beginWord);

            while (WordQueue.Any())
            {
                int queueSize = WordQueue.Count;

                for (int i = 0; i < queueSize; i++)
                {
                    var cur = WordQueue.Dequeue();
                    if (cur == endWord)
                    {
                        return ladderLength;
                    }

                    EnqueueNeighbors(cur);
                }

                ladderLength++;
            }

            return 0;
        }

        private void EnqueueNeighbors(string word)
        {
            for (int l = 0; l < word.Length; l++)
            {
                var start = word.Substring(0, l);
                var end = word.Substring(l + 1, word.Length - l - 1);

                for (int j = 0; j < AllChars.Length; j++)
                {
                    var permutation = start + AllChars[j] + end;
                    if (Words.Contains(permutation))
                    {
                        WordQueue.Enqueue(permutation);
                        Words.Remove(permutation);
                    }
                }
            }
        }
    }
}
