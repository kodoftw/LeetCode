using System;

namespace _476_NumberComplement
{
    internal class Solution
    {
        public int FindComplement(int num)
        {
            var allOnes = int.MaxValue;
            while ((allOnes & num) > 0) allOnes = allOnes << 1;
            return ~allOnes ^ num;
        }
    }
}
