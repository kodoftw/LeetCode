namespace _190_ReverseBits
{
    internal class Solution
    {
        public uint ReverseBits(uint n)
        {
            uint r = 0;

            for (int i = 0; i < 32; i++)
            {
                r = r << 1;
                if ((n & 1) == 1)
                {
                    r += 1;
                }
                n = n >> 1;
            }

            return r;
        }
    }
}
