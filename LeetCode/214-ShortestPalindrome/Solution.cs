using System;
using System.Linq;

namespace _214_ShortestPalindrome
{
    internal class Solution
    {
        public string ShortestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            int n = FindLongestPalindromeFromRoot(s);

            return ReverseRestOfString(s, n) + s;
        }

        private int FindLongestPalindromeFromRoot(string s)
        {
            for (int center = s.Length / 2; center >= 1; center--)
            {
                if (IsCenterOfOddPalindrome(s, center))
                {
                    return center * 2 + 1;
                }
                if (IsCenterOfEvenPalindrome(s, center))
                {
                    return center * 2;
                }
            }

            return 1;
        }

        private bool IsCenterOfOddPalindrome(string s, int center)
        {
            int radius = center;
            for (;
                 center - radius >= 0 && center + radius < s.Length;
                 radius--)
            {
                if (s[center - radius] != s[center + radius])
                {
                    return false;
                }
                if (radius == 1)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsCenterOfEvenPalindrome(string s, int center)
        {
            int radius = center - 1;
            for (;
                 center - radius - 1 >= 0 && center + radius < s.Length;
                 radius--)
            {
                if (s[center - radius - 1] != s[center + radius])
                {
                    return false;
                }
                if (radius == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private string ReverseRestOfString(string s, int start)
        {
            var stringToReverse = s.Substring(start, s.Length - start);

            return new string(stringToReverse.Reverse().ToArray());
        }
    }
}
