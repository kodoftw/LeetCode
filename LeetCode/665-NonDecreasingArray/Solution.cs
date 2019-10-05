namespace _665_NonDecreasingArray
{
    internal class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            if (nums.Length < 3)
                return true;

            bool foundSwap = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    if (foundSwap)
                        return false;

                    foundSwap = true;
                    if (i < 2 || nums[i - 2] <= nums[i])
                        nums[i - 1] = nums[i];
                    else
                        nums[i] = nums[i - 1];
                }
            }

            return true;
        }
    }
}
