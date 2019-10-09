﻿namespace _344_ReverseString
{
    internal class Solution
    {
        public void ReverseString(char[] s)
        {
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                char tmp = s[i];
                s[i++] = s[j];
                s[j--] = tmp;
            }
        }
    }
}
