﻿namespace _371_SumOfTwoIntegers
{
    internal class Solution
    {
        public int GetSum(int a, int b)
        {
            int sum = a;

            while (b != 0)
            {
                sum = a ^ b;
                b = (a & b) << 1;
                a = sum;
            }

            return sum;
        }
    }
}
