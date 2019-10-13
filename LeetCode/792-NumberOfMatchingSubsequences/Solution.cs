using System.Collections.Generic;

namespace _792_NumberOfMatchingSubsequences
{
    internal class Solution
    {
        IList<int>[] WordCount = new IList<int>[26];

        public int NumMatchingSubseq(string S, string[] words)
        {
            var matches = 0;

            CalculateWordIndexCount(S);

            foreach (var word in words)
            {
                if (IsSubset(word))
                {
                    matches++;
                }
            }

            return matches;
        }

        private void CalculateWordIndexCount(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                var charIndex = CharToInt(str[i]);
                if (WordCount[charIndex] == null)
                {
                    WordCount[charIndex] = new List<int>();
                }

                WordCount[charIndex].Add(i);
            }
        }

        private int CharToInt(char c)
        {
            return c - 'a';
        }

        private bool IsSubset(string word)
        {
            int lastIndex = -1;

            foreach (var c in word)
            {
                var currentIndex = GetNextIndexInWord(c, lastIndex);

                if (currentIndex == -1)
                {
                    return false;
                }

                lastIndex = currentIndex;
            }

            return true;
        }

        private int GetNextIndexInWord(char c, int startIndex)
        {
            var charIndex = CharToInt(c);

            if (WordCount[charIndex] == null)
            {
                return -1;
            }

            if (startIndex == -1)
            {
                return WordCount[charIndex][0];
            }

            return BinarySearchIndexGreaterThan(WordCount[charIndex], startIndex, 0, WordCount[charIndex].Count - 1);
        }

        private int BinarySearchIndexGreaterThan(IList<int> indices, int index, int min, int max)
        {
            if (max - min <= 1)
            {
                if (indices[min] > index)
                {
                    return indices[min];
                }
                else if (indices[max] > index)
                {
                    return indices[max];
                }
                else
                {
                    return -1;
                }
            }

            var m = (min + max) / 2;
            if (indices[m] > index)
            {
                return BinarySearchIndexGreaterThan(indices, index, min, m);
            }
            else
            {
                return BinarySearchIndexGreaterThan(indices, index, m, max);
            }
        }
    }
}
