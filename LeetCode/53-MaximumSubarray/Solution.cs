namespace _53_MaximumSubarray
{
    internal class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int largestSum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum < 0)
                {
                    if (sum > largestSum)
                    {
                        largestSum = sum;
                    }
                    sum = 0;
                    continue;
                }

                if (sum > largestSum)
                {
                    largestSum = sum;
                }
            }

            return largestSum;
        }
    }
}
