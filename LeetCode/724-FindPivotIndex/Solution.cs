namespace _724_FindPivotIndex
{
    internal class Solution
    {
        public int PivotIndex(int[] nums)
        {
            if (nums.Length < 3) return -1;

            var sumLeft = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                sumLeft[i] = i == 0 ? nums[i] : sumLeft[i - 1] + nums[i];
            }

            int pivot = -1;
            for (int i = nums.Length - 1, carry = 0; i >= 0; i--)
            {
                carry += nums[i];
                sumLeft[i] -= carry;

                if (sumLeft[i] == 0)
                    pivot = i;
            }

            return pivot;
        }
    }
}
