namespace _868_BinaryGap
{
    internal class Solution
    {
        public int BinaryGap(int N)
        {
            int max = 0;
            int current = 0;

            while (N > 0 && (N & 1) == 0)
                N >>= 1;

            while (N > 0)
            {
                N >>= 1;
                current++;

                if ((N & 1) == 1)
                {
                    if (current > max)
                    {
                        max = current;
                    }
                    current = 0;
                }
            }

            return max;
        }
    }
}
