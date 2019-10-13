namespace _338_CountingBits
{
    internal class Solution
    {
        public int[] CountBits(int num)
        {

            int curPowerOf2 = 1;
            int nextPowerOf2 = 2;
            var bitCount = new int[num + 1];

            for (int i = 1; i <= num; i++)
            {
                bitCount[i] = bitCount[i - curPowerOf2] + 1;
                if (nextPowerOf2 == i + 1)
                {
                    nextPowerOf2 <<= 1;
                    curPowerOf2 <<= 1;
                }
            }

            return bitCount;
        }
    }
}
