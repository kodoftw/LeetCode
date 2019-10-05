﻿namespace _693_BinaryNumberWithAlternatingBits
{
    internal class Solution
    {
        public bool HasAlternatingBits(int n)
        {
            return (n & (n >> 1)) == 0 && (n & (n >> 2)) == (n >> 2);
        }
    }
}
