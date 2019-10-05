namespace _191_NumberOf1Bits
{
    internal class Solution
    {
        public int HammingWeight(uint n)
        {
            if (n == 0)
            {
                return 0;
            }

            bool isOdd = (n & 1) == 1;
            return (isOdd ? 1 : 0) + HammingWeight(n >> 1);
        }
    }
}
