namespace _283_MoveZeroes
{
    internal class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int i = 0;
            while (i < nums.Length && nums[i] != 0) i++;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    nums[i] = nums[j];
                    nums[j] = 0;
                    i++;
                }
            }
        }
    }
}
