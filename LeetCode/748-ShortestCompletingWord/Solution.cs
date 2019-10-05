using System;

namespace _748_ShortestCompletingWord
{
    internal class Solution
    {
        private int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103 };

        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var primeProduct = GetPlatePrimeProduct(licensePlate);
            string ret = "aaaaaaaaaaaaaaaa";

            foreach (var word in words)
            {
                if (word.Length < ret.Length && GetPlatePrimeProduct(word) % primeProduct == 0)
                {
                    ret = word;
                }
            }

            return ret;
        }

        private long GetPlatePrimeProduct(string plate)
        {
            long ret = 1;
            var baseValue = (int)'a';

            foreach (var c in plate)
            {
                if (!Char.IsLetter(c)) continue;

                var v = ((int)Char.ToLower(c)) - baseValue;
                ret *= primes[v];
            }

            return ret;
        }
    }
}
