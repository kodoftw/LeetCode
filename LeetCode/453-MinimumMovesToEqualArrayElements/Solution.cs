namespace _453_MinimumMovesToEqualArrayElements
{
    internal class Solution
    {
        public int MinMoves(int[] nums)
        {
            int min = int.MaxValue;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }

                sum += nums[i];
            }

            return sum - min * nums.Length;
        }
    }
}
