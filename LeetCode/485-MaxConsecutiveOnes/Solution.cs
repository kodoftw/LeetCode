namespace _485_MaxConsecutiveOnes
{
    internal class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int cur = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    cur++;
                }
                else
                {
                    if (cur > max)
                    {
                        max = cur;
                    }
                    cur = 0;
                }
            }

            if (cur > max)
            {
                max = cur;
            }

            return max;
        }
    }
}
