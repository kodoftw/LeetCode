namespace _762_PrimeNumberOfSetBitsInBinaryRepresentation
{
    internal class Solution
    {
        public int CountPrimeSetBits(int L, int R)
        {
            int sum = 0;
            for (; L <= R; L++)
            {
                if (isPrime(bitCount(L)))
                {
                    sum++;
                }
            }

            return sum;
        }

        private bool isPrime(int n)
        {
            return n == 2 || n == 3 || n == 5
                || n == 7 || n == 11 || n == 13
                || n == 17 || n == 19;
        }

        private int bitCount(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    sum++;
                }

                n = n >> 1;
            }

            return sum;
        }
    }
}
